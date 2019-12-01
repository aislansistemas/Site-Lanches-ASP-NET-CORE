using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LanchesMac.Repositories.Mocks
{
    public class MockLancheRepository : ILancheRepository
    {
        private readonly ICategoriaRepository _categoriaRepository = new MockCategoriaRepository();

        public IEnumerable<Lanche> Lanches
        {
            get
            {
                return new List<Lanche>
                {
                    new Lanche {
                        Nome = "Cheese Salada",
                        Preco = 12.50M,
                        DescricaoCurta = "Pão, hambúrger, ovo, presunto, queijo e batata palha",
                        DescricaoDetalhada = "Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg",
                    },
                    new Lanche {
                        Nome = "Misto Quente",
                        Preco = 8.00M,
                        DescricaoCurta = "Pão, presunto, mussarela e tomate",
                        DescricaoDetalhada = "Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg",
                    },
                    new Lanche {
                        Nome = "Cheese Burger",
                        Preco = 11.00M,
                        DescricaoCurta = "Pão, hambúrger, presunto, mussarela e batalha palha ",
                        DescricaoDetalhada = "Pão de hambúrger especial com hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg",
                    },
                    new Lanche
                    {
                        Nome = "X-Tudo",
                        Preco = 15.00M,
                        DescricaoCurta = "Pão, Hambúrger, ovo, bacon, presunto, mussarela, alface, tomate e batata palha",
                        DescricaoDetalhada = "Pão fresquinho com hambúrger especial e ovo frito com bacon, presunto e mussarela; tomate e alface fresquinhos. Acompanha batata palha",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "http://www.macoratti.net/Imagens/lanches/cheesetudo1.jpg",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "http://www.macoratti.net/Imagens/lanches/cheesetudo1.jpg",
                    },
                     new Lanche
                    {
                        Nome = "Lanche Natural",
                        Preco = 10.00M,
                        DescricaoCurta = "Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte  ",
                        DescricaoDetalhada = "Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg",
                    }
                };
            }
        }

        public IEnumerable<Lanche> LanchesPreferidos { get; }
        public Lanche GetLancheById(int lancheId)
        {
            throw new NotImplementedException();
        }
    }
}
