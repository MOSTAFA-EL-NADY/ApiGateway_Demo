using ApiGateway.DTO;
using Department_Demo.Models;
using Newtonsoft.Json;
using Ocelot.Middleware;
using Ocelot.Multiplexer;
using Student_Demo.Models;
using System.Net;

namespace ApiGateway.Aggregators
{
    public class CustomeAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            var studentsResponse = await responses[0].Items.DownstreamResponse().Content.ReadAsStringAsync();

            var departmentsResponse = await responses[1].Items.DownstreamResponse().Content.ReadAsStringAsync();

            var students = JsonConvert.DeserializeObject<List<Student>>(studentsResponse);

            var departments = JsonConvert.DeserializeObject<List<Department>>(departmentsResponse);

            var aggregatedResult = students?.Select(student => new StudentDetails
            (
                student.Id,
                student.Name,
                departments?.FirstOrDefault(dept => dept.Id == student.DepartmentId)?.Name ?? ""
            )).ToList();

            var content = new StringContent(JsonConvert.SerializeObject(aggregatedResult), System.Text.Encoding.UTF8, "application/json");

            return new DownstreamResponse(content, HttpStatusCode.OK, new List<KeyValuePair<string, IEnumerable<string>>>(), "OK");


        }
    }
}
