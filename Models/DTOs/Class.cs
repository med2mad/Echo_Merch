using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch.Models.DTOs;

public static class zzzClass
{
    public static UserDTO zzzMethod([Bind("Name,Username")] this User u)
    {

        return new UserDTO
        {
            Name = u.Name,
            Username = u.Username
        };
    }
}
