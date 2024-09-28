using Estudo.Infra.IoC.DependencyInjector;

var builder = WebApplication.CreateBuilder(args);

//Conex�o com o banco de dados SQL
builder.Services.AddDbContextConfig(builder.Configuration);
builder.Services.AddDependencyConfig();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
