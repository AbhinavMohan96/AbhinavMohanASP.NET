using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLIbrary.DataAccess;
using DataLIbrary.Models;

namespace DataLIbrary.BusinessLogic
{
    public static class MessageProcessor
    {
        public static int CreateMessage
            (string displayName, string location, string message, bool visible)
        {
            MessagingModel data = new MessagingModel
            {
                DisplayName = displayName,
                Location = location,
                Message = message,
                Visible = visible
            };

            string sql = @"insert into MessagingApp (DisplayName, Location, Message, Visible)
                           values (@DisplayName, @Location, @Message, @Visible)";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<MessagingModel> LoadMessages()
        {
            string sql = @"select id, DisplayName, Location, Message, Visible 
                           from MessagingApp";

            return SqlDataAccess.LoadData<MessagingModel>(sql);
        }
    }
}
