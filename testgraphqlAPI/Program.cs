using testgraphqlAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();
//builder.Services.AddPooledDBContextFactory<DBContext>(o=> o.Us);


    

var app = builder.Build();

app.MapGraphQL();

app.Run();