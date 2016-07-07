using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    public class MoviesController : ApiController
    {
        public string GetMovie(string name)
        {
            MovieDetails data = new MovieDetails()
            {
                Id = 1,
                Header = "Spirited Away",
                Header_title = "2001 - Film",
                Name = "Spirited Away",
                Type = "Movie",
                Overview = new Overview()
                {
                    Discription = "In this animated feature by noted Japanese director Hayao Miyazaki, 10-year-old Chihiro (Rumi Hiiragi) and her parents (Takashi Naitô, Yasuko Sawaguchi) stumble upon a seemingly abandoned amusement park. After her mother and father are turned into giant pigs, Chihiro meets the mysterious Haku (Miyu Irino), who explains that the park is a resort for supernatural beings who need a break from their time spent in the earthly realm, and that she must work there to free herself and her parents.",
                    Header_sub_title = "Fantasy/Mystery - 2h5m",
                    Type = "Main",
                    Images = new List<string>() { "http://t1.gstatic.com/images?q=tbn:ANd9GcS6MveoDoJOg9-wMvtHE4ak_-HDZeYS1egb9PwRcf8lhrtcppMc", "http://images.mentalfloss.com/sites/default/files/styles/insert_main_wide_image/public/597876438.png", "https://blogs.commons.georgetown.edu/cctp-725-fall2013/files/2013/09/Spirited-Away.jpg", "https://i.ytimg.com/vi/_jGXcSBcvQQ/maxresdefault.jpg" },
                    Ratings = new List<Ratings>()
                    {
                        new Ratings()
                        {
                            Source = "IMDB",
                            Rating = "8.5",
                            Link = "http://imdb.com"
                        },
                        new Ratings()
                        {
                            Source = "MyAnimeList",
                            Rating = "9.5",
                            Link = "http://myanimelist.com"
                        },
                        new Ratings()
                        {
                            Source = "Metacritic",
                            Rating = "95%",
                            Link = "http://metacritic.com"
                        }
                    },
                    Additional_Discription = new Dictionary<string, string>()
                    {

                        { "Initial Release", "July 20, 2001 (Japan)" },
                        { "Director", "Hayao Miyazaki" },
                        { "Featured song", "Always With Me" },
                        { "Production company", "Studio Ghibli" },
                        { "Cast", "Rumi Hiiragi, Miyu Irino, Mari Natsuki, Ryunosuke Kamiki" }
                    }
                },
                Cast = new Cast()
                {
                    Type = "Card",
                    IncludeInMain = true,
                    data = new List<Card>()
                    {
                        new Card()
                        {
                            Image = "http://213.136.77.77/product-images/celebrities-images/2Rumi%20Hiiragi-3.jpg",
                            Link = "#",
                            Title1 = "Rumi Hiiragi",
                            Title2 = "Chihiro Ogino"
                        },
                        new Card()
                        {
                            Image = "http://www.nautiljon.com/images/people/00/40/miyu_irino_304.jpg?1458894956",
                            Link = "#",
                            Title1 = "Miyu Irino",
                            Title2 = "Haku"
                        },
                        new Card()
                        {
                            Image = "https://static.eigapedia.com/person-image/mari-natsuki.jpg",
                            Link = "#",
                            Title1 = "Mari Natsuki",
                            Title2 = "Yubaba, Zeniba"
                        },
                        new Card()
                        {
                            Image = "http://news.walkerplus.com/article/54648/299785_615.jpg",
                            Link = "#",
                            Title1 = "Ryunosuke Kamiki",
                            Title2 = "Boh"
                        },
                        new Card()
                        {
                            Image = "http://cdn.myanimelist.net/images/voiceactors/1/9500.jpg",
                            Link = "#",
                            Title1 = "Shirō Saitō",
                            Title2 = "Haku"
                        }
                    }
                },
                Characters = new Characters()
                {
                    Type = "Card",
                    includeInMain = true,
                    Data = new List<Card>()
                    {
                        new Card()
                        {
                            Link = "#",
                            Image = "http://vignette4.wikia.nocookie.net/spiritedaway/images/7/74/Yubaba.png/revision/latest?cb=20120724095042",
                            Title1 = "Yubaba",
                            Title2 = "Mari Natsuki"
                        },
                        new Card()
                        {
                            Image = "http://vignette2.wikia.nocookie.net/spiritedaway/images/1/11/HakuV2.png/revision/latest?cb=20120724100230",
                            Link = "#",
                            Title1 = "Haku",
                            Title2 = "Miyu Irino"
                        },
                        new Card()
                        {
                            Image = "http://vignette2.wikia.nocookie.net/spiritedaway/images/9/9e/Url-2.jpeg/revision/latest?cb=20130131032413",
                            Link = "#",
                            Title1 = "Kamaji",
                            Title2 = "Bunta Sugawara"
                        },
                        new Card()
                        {
                            Image = "http://vignette3.wikia.nocookie.net/ghibil/images/6/69/Chihiro.jpg/revision/latest?cb=20130628170950",
                            Link = "#",
                            Title1 = "Chihiro Ogino",
                            Title2 = "Rumi Hiragagi"
                        },
                        new Card()
                        {
                            Image = "http://vignette2.wikia.nocookie.net/disney/images/a/a2/Spirited-away-disneyscreencaps.com-13212.jpg/revision/latest?cb=20140902173058",
                            Link = "#",
                            Title1 = "Zeniba",
                            Title2 = "Mari Natsuki"
                        }
                    }
                },
                Reviews = new Reviews()
                {
                    Type = "Text List",
                    IncludeInMain = true,
                    Data = new List<Review>()
                    {
                        new Review()
                        {
                            Critic = "Patrick Peters",
                            Link = "http://www.empireonline.com/movies/spirited-away/review/",
                            Text = "Equal parts visual masterpiece, nightmare-inducing fable and slickly packaged animism.",
                            Source = "Empire"
                        },
                        new Review()
                        {
                            Critic = "Bob Smithouser",
                            Link = "http://www.pluggedin.com/movie-reviews/spiritedaway/",
                            Text = "Despite a dip midway through, this is a captivating fantasy that sets a new benchmark for animation.",
                            Source = "Plugged In"
                        }
                    }
                }
            };

            return JsonConvert.SerializeObject(data);
        }

    }
}
