using fsbr_desafio.Models;

namespace fsbr_desafio.Services
{
    public static class IbgeApi
    {
        private static string urlBase = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string urlBuscarMunicipiosPorUf = $"{urlBase}/id/municipios";
        private static HttpClient solicitacao = new HttpClient();

        public static async Task<List<UfViewModel>> BuscarUfs()
        {
            var resposta = await solicitacao.GetAsync(urlBase);
            if (resposta.IsSuccessStatusCode)
            {
                var ufs = await resposta.Content.ReadFromJsonAsync<List<UfViewModel>>();
                return ufs;
            }
            return null;
        }

        public static async Task<List<MunicipioViewModel>> BuscarMunicipiosPorUf(int ufId)
        {
            var response = await solicitacao.GetAsync($"{urlBuscarMunicipiosPorUf}/{ufId}/municipios");
            if (response.IsSuccessStatusCode)
            {
                var municipios = await response.Content.ReadFromJsonAsync<List<MunicipioViewModel>>();
                return municipios;
            }
            return null;
        }
    }
}