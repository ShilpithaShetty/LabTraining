using JWTAuth.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>

{

    options.AddPolicy(name: "MyPolicy", policy =>

    {

        policy.AllowAnyOrigin()

        .AllowAnyMethod();

    });

});

var tokenKey = builder.Configuration.GetValue<string>("TokenKey");

var key = Encoding.ASCII.GetBytes(tokenKey);



builder.Services.AddAuthentication(x =>

{

    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

})

.AddJwtBearer(x =>

{

    x.RequireHttpsMetadata = false;

    x.SaveToken = true;

    x.TokenValidationParameters = new TokenValidationParameters

    {

        ValidateIssuerSigningKey = true,

        IssuerSigningKey = new SymmetricSecurityKey(key),

        ValidateIssuer = false,

        ValidateAudience = false

    };

});

builder.Services.AddSingleton<IJWTAuthenticationManager>(new JWTAuthenticationManager(tokenKey));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
