Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidado("Maria");
ep1.AdicionarConvidado("Edgard");


Episodio ep2 = new(2, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidado("Fernada");
ep2.AdicionarConvidado("Roberto");
ep2.AdicionarConvidado("Roger");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();