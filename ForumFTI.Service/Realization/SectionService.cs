using ForumFTI.DAL.Interfaces;
using ForumFTI.DAL.Storage;
using ForumFTI.Domain.Enum;
using ForumFTI.Domain.Models;
using ForumFTI.Domain.Response;
using ForumFTI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumFTI.Service.Realization
{
    public class SectionService : ISectionService
    {
        private readonly IBaseStorage<Section> _sectionStorage;

        public SectionService(IBaseStorage<Section> sectionStorage)
        {
            _sectionStorage = sectionStorage;
        }

        public async Task<IBaseResponse<IEnumerable<Section>>> GetSections()
        {

            var response = new BaseResponse<IEnumerable<Section>>();

            try
            {
                var section = await _sectionStorage.GetAll();

                if (section.Count == 0)
                {
                    response.Description = "Найдено 0 элементов";
                    response.Status = StatusCode.NotFound;

                    return response;
                }

                response.Data = section;
                response.Status = StatusCode.OK;

                return response;
            }
            catch(Exception ex)
            {
                return new BaseResponse<IEnumerable<Section>>()
                {
                    Description = $"[GetSections] : {ex.Message}"
                };
            }

        }
    }
}
