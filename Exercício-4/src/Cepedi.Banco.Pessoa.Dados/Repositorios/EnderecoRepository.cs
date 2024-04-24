using System.Net;
using System.Text.Json;
using Cepedi.Banco.Pessoa.Dominio.Entidades;
using Cepedi.Banco.Pessoa.Dominio.Repository;
using Microsoft.EntityFrameworkCore;

namespace Cepedi.Banco.Pessoa.Dados.Repositorios;

public class EnderecoRepository : IEnderecoRepository
{
    private readonly ApplicationDbContext _context;

    public EnderecoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<EnderecoEntity> AtualizarEnderecoAsync(EnderecoEntity endereco)
    {
        _context.Endereco.Update(endereco);
        await _context.SaveChangesAsync();

        return endereco;
    }

    public async Task<EnderecoEntity> CadastrarEnderecoAsync(EnderecoEntity endereco)
    {
        _context.Endereco.Add(endereco);
        await _context.SaveChangesAsync();

        return endereco;
    }

    public async Task<EnderecoEntity> ExcluirEnderecoAsync(EnderecoEntity endereco)
    {
        _context.Endereco.Remove(endereco);
        await _context.SaveChangesAsync();

        return endereco;
    }

    public async Task<EnderecoEntity> ObterEnderecoAsync(int id)
    {
        var endereco = await _context.Endereco.FirstOrDefaultAsync(endereco => endereco.Id == id);
        return endereco;
    }

    public async Task<EnderecoEntity> ObterEnderecoPorCepAsync(string cep)
    {
        var endereco = await _context.Endereco.FirstOrDefaultAsync(endereco => endereco.Cep == cep);
        return endereco;
    }

    public async Task<List<EnderecoEntity>> ObterTodosEnderecosAsync()
    {
        var enderecos = await _context.Endereco.ToListAsync();
        return enderecos;
    }

    public async Task<object> ConsultaCeps()
    {
        string url = $"https://viacep.com.br/ws/22031012/json/";
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(url);
        if (!response.IsSuccessStatusCode)
        {
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                var responseContentError = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<EnderecoResponse>(responseContentError);
            }
            else
                throw new Exception($"Error: (response.StatusCode) - (response. ReasonPhrase)");
        }
        var responseContent = await response.Content.ReadAsStringAsync();
        var EnderecoResponse = JsonSerializer.Deserialize<EnderecoResponse>(responseContent); 
        return EnderecoResponse;
    }
    
}

internal class EnderecoResponse
{
    string Cep {get; set;}
    string Logradouro {get; set;}
    string Complemento {get; set;}
    string Bairro {get; set;}
    string Localidade {get; set;}
    string Uf {get; set;}
    int Ibge {get; set;}
   string Gia {get; set;}
   int DDD {get; set;}
   int Siafi {get; set;}
}