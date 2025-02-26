using AutoMapper;

namespace Echo_Merch.Models.DTOs;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDTO>();
        CreateMap<Contact, ContactDTO>();
    }
}
