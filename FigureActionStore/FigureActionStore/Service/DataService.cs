using FigureActionStore.Model;
using System.Collections.ObjectModel;

namespace FigureActionStore.Service
{
    public class DataService
    {
        public static ObservableCollection<Figure> GetFigureAction()
        {
            return new ObservableCollection<Figure>()
            {
                new Figure()
                {
                    Id = 1,
                    ImageFigure = "metalgearsolid.png",
                    name = "Naked Snake\n",
                    type = "Game",
                    value="R$ 178",                    
                    description ="Metal Gear Solid\n\n\n",
                    figureDetail =
                    {
                        ImageDetail = "NakedSnake.png",
                        translationX = 0,
                        detailDescription ="Metal Gear Solid\n",
                        detail = "Naked Snake é um dos\n" +
                             "personagens mais misteriosos e\n" +
                             "controversos já criados em uma\n" +
                             "história de video game. E se\n" +
                             "você jogou Metal Gear Solid 3:\n" +
                             "Snake Eater, deve ter percebido\n" +
                             "isso."
                    }
                   
                },
                new Figure()
                {
                    Id = 2,
                    ImageFigure = "kratos.png",
                    name = "Kratos\n",
                    type = "Game",
                    value="R$ 300",
                    description ="God of War\n",
                     figureDetail =
                    {
                        ImageDetail = "kratos.png",
                        detailDescription = "God of War\n",
                        translationX = 55,
                        detail = ""
                    }
                },
                new Figure()
                {
                    Id = 3,
                    ImageFigure = "luffmin.png",
                    name = "Monkey D.Luffy\n",
                    type = "Anime",
                    value="R$ 178",
                    description ="One Piece\n",
                    figureDetail =
                    {
                        ImageDetail = "luffy.png",
                        detailDescription = "One Piece\n",
                        translationX = 0,
                        detail = "Monkey D. Luffy é o\n" +
                             "protagonista do anime e mangá\n" +
                             "One Piece. Luffy é um pirata que\n" +
                             "deseja ser o Rei dos Piratas. É o\n" +
                             "capitão da tripulação do Bando\n" +
                             "do Chapéu de Palha e líder da\n" +
                             "Grande Frota dos Chapéus de\n" +
                             "Palha. "
                    }
                    
                },
                new Figure()
                {
                    Id = 4,
                    ImageFigure = "majinbull.png",
                    name = "Majin bull\n",
                    type = "Anime",
                    value="R$ 178",
                    description ="Dragon Ball Z\n",
                    figureDetail =
                    {
                        ImageDetail = "majinbull.png",
                        detailDescription = "Dragon Ball Z\n",
                        translationX = 160,
                        detail = ""
                    }
                },
                new Figure()
                {
                    Id = 5,
                    ImageFigure = "darthVader.png",
                    name = "Darth Vader\n",
                    type = "Others",
                    value="R$ 178",
                    description ="Star Wars\n",
                    figureDetail =
                    {
                        ImageDetail = "darthVader.png",
                        detailDescription = "Star Wars\n",
                        translationX = 120,
                        detail = ""
                    }
                }
            };
        }

        public static ObservableCollection<Category> GetCategoryFigureAction()
        {
            return new ObservableCollection<Category>()
            {
                new Category()
                {
                    name ="Game",
                    backgroundColor = "#BF4A45"
                },
                new Category()
                {
                    name ="Anime",
                    backgroundColor = "#2E2F33"
                },
                new Category()
                {
                    name ="Others",
                    backgroundColor = "#2E2F33"
                }
            };
        }
    }
}
