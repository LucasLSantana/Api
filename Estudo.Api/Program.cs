using Estudo.Infra.IoC.DependencyInjector;
using Hangfire;

var builder = WebApplication.CreateBuilder(args);

//Conex�o com o banco de dados SQL
builder.Services.AddDbContextConfig(builder.Configuration);
builder.Services.AddDependencyConfig();
builder.Services.AddControllers();
builder.Services.AddHangFireConfig(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var dashBoardOptions = new DashboardOptions()
{
DarkModeEnabled = true,
DashboardTitle = "Estudo API",
};

app.UseHangfireDashboard(pathMatch: "/hangfire", dashBoardOptions);
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
HangFireExtension.StartJobs();
app.Run();
