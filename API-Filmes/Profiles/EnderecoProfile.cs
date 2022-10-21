using API_Filmes.Data.Dtos.Endereco;
using API_Filmes.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Filmes.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
           
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
