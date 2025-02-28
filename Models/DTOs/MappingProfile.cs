using AutoMapper;

namespace Echo_Merch.Models.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDTO>();
        CreateMap<Contact, ContactDTO>();
    }
}
