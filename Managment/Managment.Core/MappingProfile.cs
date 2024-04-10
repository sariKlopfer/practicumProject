using AutoMapper;
using Managment.Core.DTO;
using Managment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeDTO, Employee>().ReverseMap();
            CreateMap<RoleDTO, Role>().ReverseMap();
        }
    }
}
