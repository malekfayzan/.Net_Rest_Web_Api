using System;
using System.Collections.Generic;

namespace sp_first_approach.Models
{
    public partial class UsersProof
    {
        public UsersProof()
        {
            UsersDetails = new HashSet<UsersDetail>();
        }
        public int UserProofId { get; set; }
        public string ProofName { get; set; } = null!;

        public virtual ICollection<UsersDetail> UsersDetails { get; set; }
    }


public static class UsersProofEndpoints
{
	public static void MapUsersProofEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/UsersProof", () =>
        {
            return new [] { new UsersProof() };
        })
        .WithName("GetAllUsersProofs");

        routes.MapGet("/api/UsersProof/{id}", (int id) =>
        {
            //return new UsersProof { ID = id };
        })
        .WithName("GetUsersProofById");

        routes.MapPut("/api/UsersProof/{id}", (int id, UsersProof input) =>
        {
            return Results.NoContent();
        })
        .WithName("UpdateUsersProof");

        routes.MapPost("/api/UsersProof/", (UsersProof model) =>
        {
            //return Results.Created($"/UsersProofs/{model.ID}", model);
        })
        .WithName("CreateUsersProof");

        routes.MapDelete("/api/UsersProof/{id}", (int id) =>
        {
            //return Results.Ok(new UsersProof { ID = id });
        })
        .WithName("DeleteUsersProof");  
    }
}}
