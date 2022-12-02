﻿using Entities.Models;
using Services.Contexts;
using Services.DTOs;
using Services.Exceptions;
using Services.Services.Interfaces;

namespace Services.Services.Implementations;

public class UserService : IUserService
{
    public StatusResponseDto GetStatusById(int id, int userId)
    {
        User user = DataContext.users.FirstOrDefault(item => item.Id == id);
        if (user == null)
            throw new NotFoundException();

        Status status = user.statuses.FirstOrDefault(item => item.Id == id);
        if (status is null)
            throw new NotFoundException();
       return Mappers.Mapper.Map<Status, StatusResponseDto>(status);
    }
}
