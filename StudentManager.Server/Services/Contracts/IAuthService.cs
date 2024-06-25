﻿using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models.Entity;
using System.Security.Claims;

namespace StudentManager.Server.Services.Contracts
{
    public interface IAuthService
    {
        Task<bool> CreateUserAsync(RegisterRequest createUserDto);
        Task<LoginResponse> LoginAsync(LoginRequest loginRequestDto);

        //Task<IActionResult> UpdateAsync(UpdateUserDto updateUserDto, ClaimsPrincipal user);

        Task<IActionResult> GetUserAsync(ClaimsPrincipal user);

        //Task<List<UserDto>> GetAllUsersAsync();

        Task<IActionResult> DeleteUserAsync(ClaimsPrincipal user);

        Task<IActionResult> LogOutAsync();
    }
}
