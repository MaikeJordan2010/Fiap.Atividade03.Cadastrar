using Contato.Cadastrar;
using Contato.Cadastrar.Aplicacao;
using Contato.Cadastrar.Repositorios.ContatosRepositorios;
using Contato.Cadastrar.Repositorios.Context;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddSingleton<IDbConection, DbConection>();
builder.Services.AddSingleton<IContatosComandosRepositorio, ContatosComandosRepositorio>();
builder.Services.AddSingleton<IContatoComandos, ContatoComandos>();

var host = builder.Build();
host.Run();
