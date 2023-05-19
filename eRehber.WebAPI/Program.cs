using Autofac;
using Autofac.Extensions.DependencyInjection;
using eRehber.Business.DependencyResolvers;
using eRehber.Business.DependencyResolvers.Autofac;
using eRehber.Core.DependencyResolvers;
using eRehber.Core.Extensions;
using eRehber.Core.Utilities.IoC;

namespace eRehber.WebAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
			builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));

			builder.Services.AddDependencyResolvers(new ICoreModule[]
			{
				new CoreModule(),
				new AutoMapperModule()
			});

			// Add services to the container.

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

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}