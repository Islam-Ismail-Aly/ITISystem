using ITI.BusnissLogicLayer.Dtos;
using ITI.DataAccessLayer.Data;
using System.Data;

namespace ITI.BusnissLogicLayer.Services
{
    public static class CourseService
    {
        public static DataTable GetAllCourses() => ApplicationDBContext.Select("SELECT Crs_Id, Crs_Name, Crs_Duration, Top_Id FROM Course");

        public static IEnumerable<CourseDto> GetCourses()
        {
            DataTable dataTable = GetAllCourses();

            List<CourseDto> courses = new List<CourseDto>();

            foreach (DataRow row in dataTable.Rows)
            {
                CourseDto course = new CourseDto
                {
                    Crs_Name = row["Crs_Name"].ToString(),
                    Crs_Duration = (int)row["Crs_Duration"]
                };

                courses.Add(course);
            }

            return courses;
        }

        public static int SaveCourse(CourseDto course) => ApplicationDBContext.ExecuteNonQuery($"INSERT INTO Course (Crs_Id, Crs_Name, Crs_Duration, Top_Id) VALUES({course.Crs_Id}, '{course.Crs_Name}', '{course.Crs_Duration}', {course.Top_Id})");

        public static int UpdateCourse(CourseDto course) => ApplicationDBContext.ExecuteNonQuery($"UPDATE Course SET Crs_Name='{course.Crs_Name}', Crs_Duration='{course.Crs_Duration}', Top_Id={course.Top_Id} WHERE Crs_Id = {course.Crs_Id}");

        public static int DeleteCourse(int id) => ApplicationDBContext.ExecuteNonQuery($"DELETE FROM Course WHERE Crs_Id = {id}");

        public static int GetMaxCrsIdIncrement()
        {
            DataTable dataTable = ApplicationDBContext.Select("SELECT MAX(Crs_Id) AS MaxCrsId FROM Course");

            if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["MaxCrsId"] != DBNull.Value)
            {
                int maxId = Convert.ToInt32(dataTable.Rows[0]["MaxCrsId"]);
                return maxId + 1;
            }
            else
            {
                return 1;
            }
        }

        public static CourseDto GetCourseById(int id) => ApplicationDBContext.GetById<CourseDto>($"SELECT Crs_Id, Crs_Name, Crs_Duration, Top_Id FROM Course WHERE Crs_Id = {id}");

    }

}
