namespace GororobaUI.Components.Pages
{
    public partial class Home
    {
        private string searchQuery;

        private async Task SearchRecipes()
        {
            if (!string.IsNullOrEmpty(searchQuery))
            {
                // Aqui você pode fazer a chamada à sua API ou realizar a lógica de pesquisa com o valor da searchQuery.
                // Exemplo de como você pode exibir o valor para debugging
                Console.WriteLine($"Buscando por: {searchQuery}");

                // Aqui você pode colocar a lógica de chamada para a API de receitas, passando o valor de searchQuery.
                // Exemplo de chamada à API usando HttpClient:
                // var response = await Http.GetFromJsonAsync<List<Recipe>>($"api/recipes?search={searchQuery}");
            }
            else
            {
                // Caso o campo esteja vazio, você pode exibir uma mensagem ou realizar outra ação.
                Console.WriteLine("Digite algo para pesquisar.");
            }
        }
    }
}
