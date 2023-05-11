using LabFt.RequestDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            var tokenRequester = new TokenRequester("https://bridgerstaging.lexisnexis.com/LN.WebServices/api/Token/Issue", "KyriaConSvsCITest/BMarcel30", "@Wormkernel1", "scope");
            var accessToken = await tokenRequester.GetAccessTokenAsync();

            var apiClient = new SearchService(accessToken);

            var requestData = new RequestSearchDto();

            requestData.ClientContext = new RequestClientContextDto() { ClientReference = ConstantInfos.XAPIKey };


            requestData.SearchConfiguration = new RequestSearchConfigurationDto()
            {
                PredefinedSearchName = "List Screening",
                WriteResultsToDatabase = "true",
                ExcludeScreeningListMatches = "false",
                DuplicateMatchSuppression = "false",
                DuplicateMatchSuppressionSameDivisionOnly = "false",
                AssignResultTo = new RequestAssignResultToDto()
                {
                    Division = "Default division",
                    EmailNotification = "false",
                    RolesOrUsers = new List<string>()
                    {
                        "Administrator"
                    },
                    Type = "Role"
                }
            };

            var requestName = new RequestNameDto() { First = "Donald", Last = "Trump", Middle = "John" };
            var date = new RequestDateDto { Day = 14, Month = 06, Year = 1946 };

            var additionalInfo = new List<RequestAdditionalInfoDto>()
            {
                new RequestAdditionalInfoDto(){ Date = date, Type = "DOB"  }
            };

            var addresses = new List<RequestAddressDto>()
            {
                new RequestAddressDto(){Country = "USA", Type = "Current"}
            };


            var entity = new RequestEntityDto() { Name = requestName, Addresses = addresses, AdditionalInfo = additionalInfo, EntityType= "Individual" };


            requestData.SearchInput = new RequestSearchInputDto()
            {
                Records = new List<RequestRecordDto>()
                {
                    new RequestRecordDto(){ Entity = entity}
                }
            };

            var data = await apiClient.GetDataAsync(requestData);

            Console.WriteLine("Token = " + accessToken);
            Console.ReadLine();
        }
    }
}
