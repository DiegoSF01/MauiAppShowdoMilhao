﻿namespace MauiAppShowdoMilhao
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomPerguntaFacil();
        }

        private void Button_Clicked_Proxima(object sender, EventArgs e)
        {
            string texto_alternativa = "";

            bool resposta_correta = false;

            if (alt_1.IsChecked)
            {
                texto_alternativa = alt_1.Content.ToString();
                resposta_correta = (bool)alt_1.Value;
            }

            if (alt_2.IsChecked)
            {
                texto_alternativa = alt_2.Content.ToString();
                resposta_correta = (bool)alt_2.Value;
            }

            if (alt_3.IsChecked)
            {
                texto_alternativa = alt_3.Content.ToString();
                resposta_correta = (bool)alt_3.Value;
            }

            if (alt_4.IsChecked)
            {
                texto_alternativa = alt_4.Content.ToString();
                resposta_correta = (bool)alt_4.Value;
            }

            if (resposta_correta)
            {
                this.BindingContext = App.getRandomPerguntaFacil();

                DisplayAlert("Acertou!", texto_alternativa, "Próxima");
            }
            else
            {
                DisplayAlert("Errou!", "Burro!", "Tentar novamente");
            }
        }
    }

}
