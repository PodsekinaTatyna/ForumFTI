using ForumFTI.Domain.Models;
using ForumFTI.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumFTI.Service.Interfaces
{
    public interface ISectionService
    {

        Task<IBaseResponse<IEnumerable<Section>>> GetSections();
    }
}
