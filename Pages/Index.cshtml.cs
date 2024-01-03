using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mycoreproject.Pages
{
    public class HospitalData
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? DepartmentName { get; set; }
        public string? Description { get; set; }
       
        private static DateTime Today = DateTime.Now;
        private int CurrentYear = Today.Year + 1;

        public List<HospitalData> GetHospitalData()
        {
            List<HospitalData> hospitalData = new List<HospitalData>();
            hospitalData.Add(new HospitalData
            {
                Id = 10,
                Subject = "David",
                StartTime = new DateTime(CurrentYear, 1, 2, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 2, 10, 0, 0),
                Description = "Health Checkup",
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 11,
                Subject = "John",
                StartTime = new DateTime(CurrentYear, 1, 1, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 1, 11, 30, 0),
                Description = "Tooth Erosion",
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 12,
                Subject = "Peter",
                StartTime = new DateTime(CurrentYear, 1, 2, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 2, 13, 0, 0),
                Description = "Eye and Spectacles Checkup",
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 13,
                Subject = "Stark",
                StartTime = new DateTime(CurrentYear, 1, 1, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 1, 15, 0, 0),
                Description = "Toothaches",
                DepartmentName = "DENTAL"
            });
            return hospitalData;
        }

        public List<HospitalData> GetWaitingListData()
        {
            List<HospitalData> waitingData = new List<HospitalData>();
            waitingData.Add(new HospitalData
            {
                Id = 1,
                Subject = "Steven",
                Description = "Consulting",
                DepartmentName = "GENERAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 2,
                Subject = "Milan",
                Description = "Bad Breath",
                DepartmentName = "DENTAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 3,
                Subject = "Laura",
                Description = "Extraction",
                DepartmentName = "GENERAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 4,
                Subject = "Janet",
                Description = "Gum Disease",
                DepartmentName = "DENTAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 5,
                Subject = "Adams",
                Description = "Observation",
                DepartmentName = "GENERAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 6,
                Subject = "John",
                Description = "Mouth Sores",
                DepartmentName = "DENTAL"
            });
            return waitingData;
        }
    }
}