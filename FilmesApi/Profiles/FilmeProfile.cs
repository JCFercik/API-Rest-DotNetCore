using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filmes>(); // HttpPost
            CreateMap<Filmes, ReadFilmeDto>(); // HttpGet(id)
            CreateMap<UpdateFilmeDto, Filmes>(); // HttpPut(id)
        }
    }
}
