namespace Mundial2018.Migrations
{
    using Mundial2018.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mundial2018.Models.Mundial2018Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Mundial2018.Models.Mundial2018Db context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            //*********************************************************************
            // adiciona Grupos
            var groups = new List<Groups> {
                new Groups {ID=1, GroupLetter="A"},
                new Groups {ID=2, GroupLetter="B"},
                new Groups {ID=3, GroupLetter="C"},
                new Groups {ID=4, GroupLetter="D"},
                new Groups {ID=5, GroupLetter="E"},
                new Groups {ID=6, GroupLetter="F"},
                new Groups {ID=7, GroupLetter="G"},
                new Groups {ID=8, GroupLetter="H"}
            };
            groups.ForEach(aa => context.Groups.AddOrUpdate(a => a.GroupLetter, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Seleções
            var nations = new List<Nations> {
                new Nations {ID=1, Name="Egypt", Flag="Egypt.png", GroupFK=1},
                new Nations {ID=2, Name="Russia", Flag="Russia.png", GroupFK=1},
                new Nations {ID=3, Name="Saudi Arabia", Flag="SaudiArabia.png", GroupFK=1},
                new Nations {ID=4, Name="Uruguay", Flag="Uruguay.png", GroupFK=1},
                
                new Nations {ID=5, Name="Iran", Flag="Iran.png", GroupFK=2},
                new Nations {ID=6, Name="Morocco", Flag="Morocco.png", GroupFK=2},
                new Nations {ID=7, Name="Portugal", Flag="Portugal.png", GroupFK=2},
                new Nations {ID=8, Name="Spain", Flag="Spain.png", GroupFK=2},
                
                new Nations {ID=9, Name="Australia", Flag="Australia.png", GroupFK=3},
                new Nations {ID=10, Name="Denmark", Flag="Denmark.png", GroupFK=3},
                new Nations {ID=11, Name="France", Flag="France.png", GroupFK=3},
                new Nations {ID=12, Name="Peru", Flag="Peru.png", GroupFK=3},
                
                new Nations {ID=13, Name="Argentina", Flag="Argentina.png", GroupFK=4},
                new Nations {ID=14, Name="Croatia", Flag="Croatia.png", GroupFK=4},
                new Nations {ID=15, Name="Iceland", Flag="Iceland.png", GroupFK=4},
                new Nations {ID=16, Name="Nigeria", Flag="Nigeria.png", GroupFK=4},
                
                new Nations {ID=17, Name="Brazil", Flag="Brazil.png", GroupFK=5},
                new Nations {ID=18, Name="Costa Rica", Flag="CostaRica.png", GroupFK=5},
                new Nations {ID=19, Name="Serbia", Flag="Serbia.png", GroupFK=5},
                new Nations {ID=20, Name="Switzerland", Flag="Switzerland.png", GroupFK=5},
                
                new Nations {ID=21, Name="Germany", Flag="Germany.png", GroupFK=6},
                new Nations {ID=22, Name="South Korea", Flag="SouthKorea.png", GroupFK=6},
                new Nations {ID=23, Name="Mexico", Flag="Mexico.png", GroupFK=6},
                new Nations {ID=24, Name="Sweden", Flag="Sweden.png", GroupFK=6},
                
                new Nations {ID=25, Name="Belgium", Flag="Belgium.png", GroupFK=7},
                new Nations {ID=26, Name="England", Flag="England.png", GroupFK=7},
                new Nations {ID=27, Name="Panama", Flag="Panama.png", GroupFK=7},
                new Nations {ID=28, Name="Tunisia", Flag="Tunisia.png", GroupFK=7},
                
                new Nations {ID=29, Name="Colombia", Flag="Colombia.png", GroupFK=8},
                new Nations {ID=30, Name="Japan", Flag="Japan.png", GroupFK=8},
                new Nations {ID=31, Name="Poland", Flag="Poland.png", GroupFK=8},
                new Nations {ID=32, Name="Senegal", Flag="Senegal.png", GroupFK=8},

            };
            nations.ForEach(aa => context.Nations.AddOrUpdate(a => a.Name, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Componentes
            var players = new List<Players> {
                new Players {ID=1, Name="Anthony Lopes", BirthDate=new DateTime(1990,10,01), Image="AnthonyLopes.jpg", Position="Goalkeeper",
                    Introduction="Anthony Lopes, born 1 October 1990, is a Portuguese professional footballer who plays for French club Olympique Lyonnais as a goalkeeper." +
                    "He came through the youth ranks at Lyon, being called to the first team in 2011 and making his debut the following year. He also played for them in the 2014 Coupe de la Ligue Final." +
                    "Born in France, Lopes represented Portugal internationally, totalling 36 caps at youth level including 11 for the under-21 team. He made his senior debut for the country in March 2015, and was chosen for Euro 2016.",
                    NationFK =7 },
                new Players {ID=2, Name="Beto", BirthDate=new DateTime(1982,05,01), Image="Beto.jpg", Position="Goalkeeper",
                    Introduction="António Alberto Bastos Pimparel, born 1 May 1982, known as Beto, is a Portuguese professional footballer who plays for Turkish club Göztepe S.K. as a goalkeeper." +
                    "He made a name for himself at Leixões before transferring to Porto in 2009, being a backup during two seasons. After one season in Romania with CFR Cluj he joined Sevilla in January 2013, going on appear in 87 competitive matches and winning two Europa League trophies." +
                    "Beto earned 12 caps for Portugal, being part of the squads in two World Cups and Euro 2012.",
                    NationFK =7 },
                new Players {ID=3, Name="Rui Patrício", BirthDate=new DateTime(1988,02,15), Image="RuiPatricio.jpg", Position="Goalkeeper",
                    Introduction="Rui Pedro dos Santos Patrício, born 15 February 1988, is a Portuguese professional footballer who plays as a goalkeeper for Sporting CP and the Portugal national team." +
                    "He has spent most of his career with Sporting, making his debut with the first team at only 18 and going on to appear in more than 450 official games." +
                    "Patrício earned his first cap for Portugal in 2010, after Paulo Bento's appointment as head coach. He represented the nation at the 2014 World Cup and three European Championships, winning the 2016 edition of the latter tournament.",
                    NationFK =7 },
                new Players {ID=4, Name="Cédric", BirthDate=new DateTime(1991,08,31), Image="Cedric.jpg", Position="Defender",
                    Introduction="Cédric Ricardo Alves Soares, born 31 August 1991, known simply as Cédric, is a Portuguese professional footballer who plays as a right back for Premier League club Southampton and the Portugal national team." +
                    "His career started with Sporting CP, going on to appear in 94 competitive games over the course of four Primeira Liga seasons and scoring two goals. He signed for Southampton in 2015." +
                    "Having earned 72 caps across all youth levels, Cédric made his senior debut for Portugal in 2014.He appeared for the country at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=5, Name="Mário Rui", BirthDate=new DateTime(1991,05,27), Image="MarioRui.jpg", Position="Defender",
                    Introduction="Mário Rui Silva Duarte, born 27 May 1991, known as Mário Rui, is a Portuguese footballer who plays for Italian club S.S.C. Napoli on loan from A.S. Roma as a left back.",
                    NationFK =7 },
                new Players {ID=6, Name="Raphael Guerreiro", BirthDate=new DateTime(1993,12,22), Image="RaphaelGuerreiro.jpg", Position="Defender",
                    Introduction="Raphaël Adelino José Guerreiro, born 22 December 1993 is a Portuguese professional footballer who plays for German club Borussia Dortmund and the Portuguese national team mainly as a left back but also as a left midfielder." +
                    "Born in France, he began his career at Caen, signing in 2013 with Lorient where he made his Ligue 1 debut. In June 2016, he joined Borussia Dortmund." +
                    "Guerreiro represented Portugal at under-21 and senior level, first appearing for the latter in 2014.He was part of their squad at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=7, Name="Ricardo Pereira", BirthDate=new DateTime(1993,10,06), Image="RicardoPereira.jpg", Position="Defender",
                    Introduction="Ricardo Domingos Barbosa Pereira, born 6 October 1993, known simply as Ricardo, is a Portuguese footballer who plays for Leicester City as a full-back.",
                    NationFK =7 },
                new Players {ID=8, Name="Bruno Alves", BirthDate=new DateTime(1981,11,27), Image="BrunoAlves.jpg", Position="Defender",
                    Introduction="Bruno Eduardo Regufe Alves, born 27 November 1981, is a Portuguese professional footballer who plays as a centre back for Scottish Premiership club Rangers and the Portugal national team." +
                    "He began and has spent most of his professional career at Porto, where he won a total of nine titles and appeared in 171 official games. He has also won trophies in Russia, with Zenit Saint Petersburg, and in Turkey, with Fenerbahçe." +
                    "A senior Portugal international since 2007, Alves represented the country in two World Cups, three European Championships and one Confederations Cup, winning Euro 2016.",
                    NationFK =7 },
                new Players {ID=9, Name="José Fonte", BirthDate=new DateTime(1983,12,22), Image="JoseFonte.jpg", Position="Defender",
                    Introduction="José Miguel da Rocha Fonte, born 22 December 1983, is a Portuguese professional footballer who plays as a centre back for Chinese club Dalian Yifang F.C. and the Portugal national team." +
                    "He started his professional career with Sporting CP B, moving to England with Crystal Palace in 2007. In 2010 he signed with Southampton, where he made 288 appearances in all competitions, until he joined West Ham in January 2017." +
                    "A Portuguese international since age 30, Fonte was part of the squad at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=10, Name="Pepe", BirthDate=new DateTime(1983,02,26), Image="Pepe.jpg", Position="Defender",
                    Introduction="Kepler Laveran de Lima Ferreira, born 26 February 1983, known as Pepe, is a Portuguese professional footballer who plays as a centre back for Turkish club Be?ikta? and the Portugal national team. During his professional career he has played for Marítimo, Porto and Real Madrid, with individual and team success with the latter two clubs. Notably, he won three league titles, three European Cups, and played 334 games for Real Madrid. An aggressive, physically strong and tenacious defender, Pepe is known for his hard-tackling style of play. However, despite his defensive abilities, he has also drawn criticism in the press at times, due to his tendency to pick up cards, as he has occasionally shown violent or unsportsmanlike behaviour on the pitch." +
                    "Born and raised in Brazil, Pepe opted to play for the Portugal national team, playing at two FIFA World Cups and three UEFA European Championships.He was a member of the team that won UEFA Euro 2016, also reaching the semi - final of Euro 2012.His father named him Kepler Laveran in honor to scientists Johannes Kepler and Charles Louis Alphonse Laveran.",
                    NationFK =7 },
                new Players {ID=11, Name="Rúben Dias", BirthDate=new DateTime(1997,05,14), Image="RubenDias.jpg", Position="Defender",
                    Introduction="Rúben Santos Gato Alves Dias, born 14 May 1997, is a Portuguese professional footballer who plays for Benfica as a defender.",
                    NationFK =7 },
                new Players {ID=12, Name="Adrien Silva", BirthDate=new DateTime(1989,03,15), Image="AdrienSilva.jpg", Position="Midfielder",
                    Introduction="Adrien Sébastien Perruchet da Silva, born 15 March 1989, known as Adrien Silva, is a Portuguese professional footballer who plays for English club Leicester City and the Portugal national team as a central midfielder." +
                    "He played mostly for Sporting since making his first - team debut at the age of 18, and was loaned to Maccabi Haifa and Académica, winning the Taça de Portugal with the latter in addition to the same honour at Sporting; with his main club, he appeared in 237 competitive games and scored 39 goals." +
                    "Known for his dribbling and passing qualities, Silva earned 46 caps for Portugal all youth categories comprised, including 13 for the under-21 team.He made his senior debut in 2014, and represented the nation at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=13, Name="Bruno Fernandes", BirthDate=new DateTime(1994,09,08), Image="BrunoFernandes.jpg", Position="Midfielder",
                    Introduction="Bruno Miguel Borges Fernandes, born 8 September 1994, is a Portuguese footballer who plays for Sporting CP as a midfielder." +
                    "He spent most of his professional career in Italy, amassing Serie A totals of 119 games and 15 goals in representation of Udinese and Sampdoria.",
                    NationFK =7 },
                new Players {ID=14, Name="Manuel Fernandes", BirthDate=new DateTime(1986,02,05), Image="ManuelFernandes.jpg", Position="Midfielder",
                    Introduction="Manuel Henrique Tavares Fernandes,born 5 February 1986, is a Portuguese professional footballer who plays for Russian club FC Lokomotiv Moscow as a midfielder." +
                    "He started his professional career with Benfica at only 18, then went on to compete in England and Spain, mainly at the service of Everton and Valencia. He signed with Be?ikta? in January 2011, spending the following three-and-a-half seasons with the club before joining Lokomotiv Moscow." +
                    "Fernandes represented the Portugal under-21 team in two European Championships. He made his debut with the full side in 2005.",
                    NationFK =7 },
                new Players {ID=15, Name="João Mário", BirthDate=new DateTime(1993,01,19), Image="JoaoMario.jpg", Position="Midfielder",
                    Introduction="João Mário Naval da Costa Eduardo, born 19 January 1993, is a Portuguese professional footballer who plays for English club West Ham United on loan from Internazionale, and the Portugal national team, as a midfielder." +
                    "He started out at Sporting CP in whose youth system he developed, being loaned to Vitória de Setúbal in 2014 and subsequently returning to be an important part of the squads that won major trophies, including the 2015 Portuguese Cup." +
                    "João Mário made his senior debut for Portugal in 2014.He appeared for the nation at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=16, Name="João Moutinho", BirthDate=new DateTime(1986,09,08), Image="JoaoMoutinho.jpg", Position="Midfielder",
                    Introduction="João Filipe Iria Santos Moutinho, born 8 September 1986, is a Portuguese footballer who plays for AS Monaco FC and the Portugal national team. Mainly a central midfielder he can also operate as a defensive or attacking midfielder, and on either flank." +
                    "He started his professional career with Sporting, moving in 2010 to Porto and winning 12 major titles between the two clubs combined. Three years later, he transferred to Monaco for €25 million." +
                    "Moutinho represented the Portuguese national team at three European Championships and the 2014 World Cup, winning the 2016 edition of the former tournament.",
                    NationFK =7 },
                new Players {ID=17, Name="William Carvalho", BirthDate=new DateTime(1992,04,07), Image="WilliamCarvalho.jpg", Position="Midfielder",
                    Introduction="William Silva de Carvalho, born 7 April 1992, is a Portuguese professional footballer who plays for Sporting CP and the Portugal national team as a defensive midfielder." +
                    "He spent most of his career with Sporting since making his debut with the first team at the age of 18, going on to appear in 188 competitive games and win the 2015 Portuguese Cup." +
                    "A full international for Portugal since 2013, Carvalho represented the nation at the 2014 World Cup and Euro 2016, winning the latter tournament.",
                    NationFK =7 },
                new Players {ID=18, Name="Bernardo Silva", BirthDate=new DateTime(1994,08,10), Image="BernardoSilva.jpg", Position="Forward",
                    Introduction="Bernardo Mota Veiga de Carvalho e Silva, born 10 August 1994, is a Portuguese professional footballer who plays for English club Manchester City and the Portugal national team as a midfielder.",
                    NationFK =7 },
                new Players {ID=19, Name="Gelson Martins", BirthDate=new DateTime(1995,05,11), Image="GelsonMartins.jpg", Position="Forward",
                    Introduction="Gelson Dany Batalha Martins, born 11 May 1995, is a Portuguese professional footballer who plays for Sporting CP and the Portugal national team as a winger.",
                    NationFK =7 },
                new Players {ID=20, Name="Gonçalo Guedes", BirthDate=new DateTime(1996,11,29), Image="GoncaloGuedes.jpg", Position="Forward",
                    Introduction="Gonçalo Manuel Ganchinho Guedes, born 29 November 1996, is a Portuguese professional footballer who plays for Spanish club Valencia CF on loan from Paris Saint-Germain as a winger." +
                    "He began his career at Benfica, making his professional debut for the reserves in April 2014 and the first team six months later.After 11 goals in 63 games across all competitions, winning five major trophies, he transferred to Paris Saint - Germain for a fee of €30 million in January 2017." +
                    "Guedes has earned over 50 caps for Portugal at youth level, from under-15 to under - 23.He made his senior international debut in November 2015, at the age of 18.",
                    NationFK =7 },
                new Players {ID=21, Name="Ricardo Quaresma", BirthDate=new DateTime(1983,09,26), Image="RicardoQuaresma.jpg", Position="Forward",
                    Introduction="Ricardo Andrade Quaresma Bernardo, born 26 September 1983, is a Portuguese professional footballer who plays as a winger for Turkish club Be?ikta? and the Portugal national team." +
                    "Quaresma began his career at Sporting CP, and has also played for Barcelona, Inter Milan, Chelsea, Be?ikta? and Al - Ahli Dubai, however he spent the best years of his career at Porto. He is popular for incorporating a repertoire of tricks into his style of play, including the rabona and trivela. A winger who can play on either flank, his qualities of speed and finesse cause a regular problem for opposing defenses." +
                    "A full international since 2003, Quaresma has over 70 caps for Portugal and represented them at three European Championships, including his nation's victorious campaign at UEFA Euro 2016, also reaching the semi-finals at Euro 2012.",
                    NationFK =7 },
                new Players {ID=22, Name="André Silva", BirthDate=new DateTime(1995,11,06), Image="AndreSilva.jpg", Position="Forward",
                    Introduction="André Miguel Valente da Silva, born 6 November 1995, is a Portuguese professional footballer who plays as a striker for Italian club A.C. Milan and the Portugal national team." +
                    "An academy graduate of Porto, he impressed during his time with the reserve side before making his debut with the first team in 2015. He ultimately made over 50 appearances for the club, scoring 24 goals before joining Milan in 2017." +
                    "Silva represented Portugal at various youth levels, and was part of the squad which came second at the 2014 European Under - 19 Championship.His senior international debut followed two years later, and he featured at the 2017 Confederations Cup where his team came third.",
                    NationFK =7 },
                new Players {ID=23, Name="Cristiano Ronaldo", BirthDate=new DateTime(1985,02,05), Image="CristianoRonaldo.jpg", Position="Forward",
                    Introduction ="Cristiano Ronaldo dos Santos Aveiro , born 5 February 1985, is a Portuguese professional footballer who plays as a forward for Spanish club Real Madrid and the Portugal national team. Often considered the best player in the world and widely regarded as one of the greatest of all time,[note 1] Ronaldo has a record-tying five Ballon d'Or awards, the most for a European player, and is the first player to win four European Golden Shoes. He has won 25 trophies in his career, including five league titles, four UEFA Champions League titles and one UEFA European Championship. Both a prolific goalscorer and playmaker, Ronaldo holds the records for most official goals scored in Europe's top-five leagues, the UEFA Champions League, the UEFA European Championship, as well as those for most assists in the UEFA Champions League and the UEFA European Championship. He has scored over 650 senior career goals for club and country." +
                    "Born and raised on the Portuguese island of Madeira, Ronaldo was diagnosed with a racing heart at age 15. He underwent an operation to treat his condition, and began his senior club career playing for Sporting CP, before signing with Manchester United at age 18 in 2003.After winning his first trophy, the FA Cup, during his first season in England, he helped United win three successive Premier League titles, a UEFA Champions League title, and a FIFA Club World Cup.By age 22, he had received Ballon d'Or and FIFA World Player of the Year nominations and at age 23, he won his first Ballon d'Or and FIFA World Player of the Year awards.In 2009, Ronaldo was the subject of the most expensive association football transfer when he moved from Manchester United to Real Madrid in a transfer worth €94 million." +
                    "In Spain, Ronaldo has won 14 trophies, including two La Liga titles, two Copas del Rey, three UEFA Champions League titles, two UEFA Super Cups, and three FIFA Club World Cups.After joining Real Madrid, Ronaldo finished runner - up for the Ballon d'Or three times, behind Lionel Messi, his perceived career rival, before winning back-to-back Ballons d'Or in 2013 and 2014.Real Madrid's all-time leading goalscorer, Ronaldo has scored a record 34 La Liga hat-tricks, including a record-tying eight hat-tricks in the 2014–15 season and is the only player to reach 30 league goals in six consecutive La Liga seasons. Ronaldo won back-to-back Ballons d'Or for a second time, winning by a record voting margin in 2016 after sealing La Undécima, Madrid's 11th European title, and winning Euro 2016, and in 2017 after firing Madrid to the first back-to-back UEFA Champions League victory in history." +
                    "A Portuguese international, Ronaldo was named the best Portuguese player of all time by the Portuguese Football Federation in 2015.Ronaldo made his senior international debut in August 2003, at age 18.He is Portugal's most capped player of all time with over 140 caps, and has participated in seven major tournaments. He is Portugal's all - time top goalscorer.He scored his first international goal at Euro 2004 and helped Portugal reach the final.He took over full captaincy in July 2008, leading Portugal to their first - ever triumph in a major tournament by winning Euro 2016, and received the Silver Boot as the second - highest goalscorer of the tournament.One of the most marketable sportsmen, he was ranked the world's highest-paid athlete by Forbes in 2016 and 2017, as well as the world's most famous athlete by ESPN in 2016 and 2017.",
                    NationFK =7 },

            };
            players.ForEach(aa => context.Players.AddOrUpdate(a => a.Name, aa));
            context.SaveChanges();


        }
    }
}
