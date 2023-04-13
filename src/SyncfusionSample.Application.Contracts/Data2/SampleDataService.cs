using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SyncfusionSample.Products;
using SyncfusionSample.Projects;
using Volo.Abp.DependencyInjection;


namespace SyncfusionSample.Data2
{
    public class SampleDataService : ISingletonDependency
    {
        private List<ProjectDto> DataSource = new List<ProjectDto>()
        {
            new ProjectDto
            {
                Id = Guid.NewGuid(),
                Name= "Asset tracking and monitoring system",
                Description="The \"TrackMaster\" system uses RFID technology for real-time tracking and monitoring of assets, providing businesses with insights, alerts, and analytics for efficient asset management.",
                URL="https://ghbjn"
            },
             new ProjectDto
            {
                Id = Guid.NewGuid(),
                Name= "Asset valuation and financial reporting",
                Description="The \"ValuPro\" software automates asset valuation calculations and generates compliant financial reports for accurate and transparent financial reporting in businesses.",
                URL="https://gdbjn"
            }
        };
        public List<ProjectDto> GetProjects()
        {
            return DataSource;
        }

        public ProjectDto GetProject(Guid id)
        {
            return DataSource.SingleOrDefault(x => x.Id == id);
        }
        public ProjectDto CreateProject(ProjectDto input)
        {
            DataSource.Add(new ProjectDto
            {
                Id = input.Id,
                Name = input.Name,
                Description = input.Description,
                URL= input.URL

            });

            return input;
        }
        public ProjectDto UpdateProject(ProjectDto input)
        {
            DeleteProject(input);
            CreateProject(input);

            return input;
        }
        public void DeleteProject(ProjectDto input) 
        {
            DataSource.Remove(input);
        }


    }
}
