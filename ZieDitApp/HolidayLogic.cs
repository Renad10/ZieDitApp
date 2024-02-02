using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZieDitApp.MVVM.Models.ApiModels;

namespace ZieDitApp
{
    public class HolidayLogic
    {
        public async static Task<List<Holiday>> GetHolidays(string year)
        {
            List<Holiday>? holidaysList = new List<Holiday>();

            var url = string.Format(Constants.GET_HOLIDAY, year);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();
                var GetHolidaysResponse = JsonConvert.DeserializeObject<Example>(json);
                holidaysList = GetHolidaysResponse?.response.holidays?.ToList();
            }
            return holidaysList;
        }
    }
}
