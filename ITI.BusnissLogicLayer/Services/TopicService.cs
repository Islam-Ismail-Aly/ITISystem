using ITI.BusnissLogicLayer.Dtos;
using ITI.DataAccessLayer.Data;
using System.Data;

namespace ITI.BusnissLogicLayer.Services
{
    public static class TopicService
    {
        public static DataTable GetAllTopics() => ApplicationDBContext.Select("SELECT Top_Id, Top_Name FROM Topic");

        public static TopicDto GetTopicById(int id) => ApplicationDBContext.GetById<TopicDto>($"SELECT Top_Id, Top_Name FROM Topic WHERE Top_Id = {id}");
    }
}
