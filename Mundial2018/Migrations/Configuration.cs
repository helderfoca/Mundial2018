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
            // adiciona Seleções
            var nations = new List<Nations> {
                new Nations {ID=1, Name="Egypt", Wins=0, Participations=3, Caption="Egypt have qualified for the FIFA World Cup on three occasions, in 1934, 1990 and 2018.",
                    Flag ="Egypt.png", Anthem="T3uTo3MLgIM", Group="A"},
                new Nations {ID=2, Name="Russia", Wins=0, Participations=11, Caption="Russia has participated in 3 FIFA World Cups since its independence in December 1991 and its the host of FIFA World Cup 2018",
                    Flag ="Russia.png", Anthem="6SixoGCptgg", Group="A"},
                new Nations {ID=3, Name="Saudi Arabia", Wins=0, Participations=5, Caption="Saudi Arabia have played in five FIFA World Cup tournaments, which were in 1994, 1998, 2002, 2006 and 2018.",
                    Flag ="SaudiArabia.png", Anthem="YjvXMCwLeCw", Group="A"},
                new Nations {ID=4, Name="Uruguay", Wins=2, Participations=13, Caption="Uruguay has won two FIFA World Cups, including the 1st ever World Cup in 1930 as hosts.",
                    Flag ="Uruguay.png", Anthem="uHUIUN-PiYo", Group="A"},
                
                new Nations {ID=5, Name="Iran", Wins=0, Participations=5, Caption="Iran have appeared in the group stage of the FIFA World Cup on five occasions in 1978, 1998, 2006, 2014, and 2018.",
                    Flag ="Iran.png", Anthem="vNg2uRLwTO0", Group="B"},
                new Nations {ID=6, Name="Morocco", Wins=0, Participations=5, Caption="Morocco have qualified for the FIFA World Cup on five occasions, which were in 1970, 1986, 1994, 1998 and 2018.",
                    Flag ="Morocco.png", Anthem="uIKWKeoCJW0", Group="B"},
                new Nations {ID=7, Name="Portugal", Wins=0, Participations=7, Caption="Portugal have appeared in the finals of FIFA World Cup on seven occasions, the first being in 1966 where they reached the semi final.",
                    Flag ="Portugal.png", Anthem="gFpl1iDl42A", Group="B"},
                new Nations {ID=8, Name="Spain", Wins=1, Participations=15, Caption="Spain is one of only eight countries ever to have won the FIFA World Cup, which it did at the 2010 FIFA World Cup, in South Africa.",
                    Flag ="Spain.png", Anthem="mjrrVrmdK0M", Group="B"},
                
                new Nations {ID=9, Name="Australia", Wins=0, Participations=5, Caption="The Australia national soccer team has represented Australia at the FIFA World Cup on five occasions: in 1974, 2006, 2010, 2014 and 2018.",
                    Flag ="Australia.png", Anthem="aQyiZNZaj00", Group="C"},
                new Nations {ID=10, Name="Denmark", Wins=0, Participations=5, Caption="The first time Denmark entered the tournament was for the 1958 edition in Sweden.",
                    Flag ="Denmark.png", Anthem="1sHnFBNqKJg", Group="C"},
                new Nations {ID=11, Name="France", Wins=1, Participations=15, Caption="The French team won its first and only World Cup title in 1998.",
                    Flag ="France.png", Anthem="C7nnYkhYprA", Group="C"},
                new Nations {ID=12, Name="Peru", Wins=0, Participations=5, Caption="Peru participated in the World Cup during the first World Cup in 1930 and in every tournament since 1958.",
                    Flag ="Peru.png", Anthem="atf_kRHWm1U", Group="C"},
                
                new Nations {ID=13, Name="Argentina", Wins=2, Participations=17, Caption="Argentina is one of the most successful national football teams in the world, having won 2 World Cups in 1978 and 1986.",
                    Flag ="Argentina.png", Anthem="L7NJDsUH8ZQ", Group="D"},
                new Nations {ID=14, Name="Croatia", Wins=0, Participations=5, Caption="Croatia national football team have appeared in the finals of the FIFA World Cup on five occasions (in 1998, 2002, 2006, 2014 and 2018).",
                    Flag ="Croatia.png", Anthem="KL-hIj1ki8c", Group="D"},
                new Nations {ID=15, Name="Iceland", Wins=0, Participations=1, Caption="After 12 failed qualification campaigns, Iceland qualified for the FIFA World Cup, for the first time, in 2018.",
                    Flag ="Iceland.png", Anthem="qic_vKjNQz8", Group="D"},
                new Nations {ID=16, Name="Nigeria", Wins=0, Participations=6, Caption="Nigeria have appeared in the finals of the FIFA World Cup on six occasions, the first being in 1994 where they reached the second round.",
                    Flag ="Nigeria.png", Anthem="xtoxuvHf9m0", Group="D"},
                
                new Nations {ID=17, Name="Brazil", Wins=5, Participations=21, Caption="Brazil is the most successful national team in the history of the World Cup, having won five titles.",
                    Flag ="Brazil.png", Anthem="dxLEvDig9Do", Group="E"},
                new Nations {ID=18, Name="Costa Rica", Wins=0, Participations=5, Caption="Costa Rica have qualified for five FIFA World Cup finals, namely in 1990, 2002, 2006, 2014 and 2018.",
                    Flag ="CostaRica.png", Anthem="b0TL78RFCiw", Group="E"},
                new Nations {ID=19, Name="Serbia", Wins=0, Participations=12, Caption="From 2006 to the present, Serbia played as an independent country.",
                    Flag ="Serbia.png", Anthem="Iu_Wz_buPOk", Group="E"},
                new Nations {ID=20, Name="Switzerland", Wins=0, Participations=11, Caption="Switzerland have appeared in the finals of the World Cup on ten occasions, the first being at the second finals in 1934 where they finished in seventh position.",
                    Flag ="Switzerland.png", Anthem="5zwClo_t7EM", Group="E"},
                
                new Nations {ID=21, Name="Germany", Wins=4, Participations=19, Caption="The Germany national football team is one of the most successful national teams at the FIFA World Cup, winning four titles.",
                    Flag ="Germany.png", Anthem="GVsUEfH299A", Group="F"},
                new Nations {ID=22, Name="South Korea", Wins=0, Participations=10, Caption="South Korea have appeared in the FIFA World Cup on nine occasions in 1954 and 1986 to 2014.",
                    Flag ="SouthKorea.png", Anthem="zN3wzPR0O7I", Group="F"},
                new Nations {ID=23, Name="Mexico", Wins=0, Participations=16, Caption="The Mexico national team has competed in the tournament since the inaugural 1930 FIFA World Cup, and has entered ever since, for a total of 15 tournaments,",
                    Flag ="Mexico.png", Anthem="yQYs1bfOgws", Group="F"},
                new Nations {ID=24, Name="Sweden", Wins=0, Participations=12, Caption="Sweden have been one of the more successful national teams in the history of the World Cup, having reached 4 semi-finals.",
                    Flag ="Sweden.png", Anthem="2_Mfjvu8ios", Group="F"},
                
                new Nations {ID=25, Name="Belgium", Wins=0, Participations=13, Caption="Belgium have appeared in the finals tournament of the FIFA World Cup on twelve occasions, the first being at the first FIFA World Cup in 1930.",
                    Flag ="Belgium.png", Anthem="Wtl8VN2lWaI", Group="G"},
                new Nations {ID=26, Name="England", Wins=1, Participations=15, Caption="England are one of only eight countries ever to win the World Cup, which they did in 1966 when they hosted the finals.",
                    Flag ="England.png", Anthem="3GFjGbIP79o", Group="G"},
                new Nations {ID=27, Name="Panama", Wins=0, Participations=1, Caption="Panama qualified once for the finals of a FIFA World Cup, the 2018 edition.",
                    Flag ="Panama.png", Anthem="ajQnO3EzkI8", Group="G"},
                new Nations {ID=28, Name="Tunisia", Wins=0, Participations=5, Caption="Tunisia have appeared in the finals of the FIFA World Cup on four occasions, the first being at the 1978 FIFA World Cup.",
                    Flag ="Tunisia.png", Anthem="qmcZzGDwhgo", Group="G"},
                
                new Nations {ID=29, Name="Colombia", Wins=0, Participations=6, Caption="Colombia has appeared in the finals of the FIFA World Cup on six occasions in 1962, 1990, 1994, 1998, 2014 and 2018.",
                    Flag ="Colombia.png", Anthem="onFfrB50Y8w", Group="H"},
                new Nations {ID=30, Name="Japan", Wins=0, Participations=6, Caption="Japan have appeared in the finals of the FIFA World Cup on five occasions, the first being in 1998.",
                    Flag ="Japan.png", Anthem="teeOavr7yLg", Group="H"},
                new Nations {ID=31, Name="Poland", Wins=0, Participations=8, Caption="Poland have qualified for the finals on eight occasions, the last time for 2018.",
                    Flag ="Poland.png", Anthem="ZUS8wbD_ZKQ", Group="H"},
                new Nations {ID=32, Name="Senegal", Wins=0, Participations=2, Caption="Senegal have appeared in the finals of the FIFA World Cup on two occasions.",
                    Flag ="Senegal.png", Anthem="1CBYHhKplmY", Group="H"},

            };
            nations.ForEach(aa => context.Nations.AddOrUpdate(a => a.Name, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Componentes
            var players = new List<Players> {
                new Players {ID=1, Name="Anthony Lopes", Image="AnthonyLopes.jpg", Position="Goalkeeper",
                    Introduction="Anthony Lopes, born 1 October 1990, is a Portuguese professional footballer who plays for French club Olympique Lyonnais as a goalkeeper." +
                    "He came through the youth ranks at Lyon, being called to the first team in 2011 and making his debut the following year. He also played for them in the 2014 Coupe de la Ligue Final." +
                    "Born in France, Lopes represented Portugal internationally, totalling 36 caps at youth level including 11 for the under-21 team. He made his senior debut for the country in March 2015, and was chosen for Euro 2016.",
                    NationFK =7 },
                new Players {ID=2, Name="Beto", Image="Beto.jpg", Position="Goalkeeper",
                    Introduction="António Alberto Bastos Pimparel, born 1 May 1982, known as Beto, is a Portuguese professional footballer who plays for Turkish club Göztepe S.K. as a goalkeeper." +
                    "He made a name for himself at Leixões before transferring to Porto in 2009, being a backup during two seasons. After one season in Romania with CFR Cluj he joined Sevilla in January 2013, going on appear in 87 competitive matches and winning two Europa League trophies." +
                    "Beto earned 12 caps for Portugal, being part of the squads in two World Cups and Euro 2012.",
                    NationFK =7 },
                new Players {ID=3, Name="Rui Patrício", Image="RuiPatricio.jpg", Position="Goalkeeper",
                    Introduction="Rui Pedro dos Santos Patrício, born 15 February 1988, is a Portuguese professional footballer who plays as a goalkeeper for Sporting CP and the Portugal national team." +
                    "He has spent most of his career with Sporting, making his debut with the first team at only 18 and going on to appear in more than 450 official games." +
                    "Patrício earned his first cap for Portugal in 2010, after Paulo Bento's appointment as head coach. He represented the nation at the 2014 World Cup and three European Championships, winning the 2016 edition of the latter tournament.",
                    NationFK =7 },
                new Players {ID=4, Name="Cédric", Image="Cedric.jpg", Position="Defender",
                    Introduction="Cédric Ricardo Alves Soares, born 31 August 1991, known simply as Cédric, is a Portuguese professional footballer who plays as a right back for Premier League club Southampton and the Portugal national team." +
                    "His career started with Sporting CP, going on to appear in 94 competitive games over the course of four Primeira Liga seasons and scoring two goals. He signed for Southampton in 2015." +
                    "Having earned 72 caps across all youth levels, Cédric made his senior debut for Portugal in 2014.He appeared for the country at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=5, Name="Mário Rui", Image="MarioRui.jpg", Position="Defender",
                    Introduction="Mário Rui Silva Duarte, born 27 May 1991, known as Mário Rui, is a Portuguese footballer who plays for Italian club S.S.C. Napoli on loan from A.S. Roma as a left back.",
                    NationFK =7 },
                new Players {ID=6, Name="Raphael Guerreiro", Image="RaphaelGuerreiro.jpg", Position="Defender",
                    Introduction="Raphaël Adelino José Guerreiro, born 22 December 1993 is a Portuguese professional footballer who plays for German club Borussia Dortmund and the Portuguese national team mainly as a left back but also as a left midfielder." +
                    "Born in France, he began his career at Caen, signing in 2013 with Lorient where he made his Ligue 1 debut. In June 2016, he joined Borussia Dortmund." +
                    "Guerreiro represented Portugal at under-21 and senior level, first appearing for the latter in 2014.He was part of their squad at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=7, Name="Ricardo Pereira", Image="RicardoPereira.jpg", Position="Defender",
                    Introduction="Ricardo Domingos Barbosa Pereira, born 6 October 1993, known simply as Ricardo, is a Portuguese footballer who plays for Leicester City as a full-back.",
                    NationFK =7 },
                new Players {ID=8, Name="Bruno Alves", Image="BrunoAlves.jpg", Position="Defender",
                    Introduction="Bruno Eduardo Regufe Alves, born 27 November 1981, is a Portuguese professional footballer who plays as a centre back for Scottish Premiership club Rangers and the Portugal national team." +
                    "He began and has spent most of his professional career at Porto, where he won a total of nine titles and appeared in 171 official games. He has also won trophies in Russia, with Zenit Saint Petersburg, and in Turkey, with Fenerbahçe." +
                    "A senior Portugal international since 2007, Alves represented the country in two World Cups, three European Championships and one Confederations Cup, winning Euro 2016.",
                    NationFK =7 },
                new Players {ID=9, Name="José Fonte", Image="JoseFonte.jpg", Position="Defender",
                    Introduction="José Miguel da Rocha Fonte, born 22 December 1983, is a Portuguese professional footballer who plays as a centre back for Chinese club Dalian Yifang F.C. and the Portugal national team." +
                    "He started his professional career with Sporting CP B, moving to England with Crystal Palace in 2007. In 2010 he signed with Southampton, where he made 288 appearances in all competitions, until he joined West Ham in January 2017." +
                    "A Portuguese international since age 30, Fonte was part of the squad at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=10, Name="Pepe", Image="Pepe.jpg", Position="Defender",
                    Introduction="Kepler Laveran de Lima Ferreira, born 26 February 1983, known as Pepe, is a Portuguese professional footballer who plays as a centre back for Turkish club Be?ikta? and the Portugal national team. During his professional career he has played for Marítimo, Porto and Real Madrid, with individual and team success with the latter two clubs. Notably, he won three league titles, three European Cups, and played 334 games for Real Madrid. An aggressive, physically strong and tenacious defender, Pepe is known for his hard-tackling style of play. However, despite his defensive abilities, he has also drawn criticism in the press at times, due to his tendency to pick up cards, as he has occasionally shown violent or unsportsmanlike behaviour on the pitch." +
                    "Born and raised in Brazil, Pepe opted to play for the Portugal national team, playing at two FIFA World Cups and three UEFA European Championships.He was a member of the team that won UEFA Euro 2016, also reaching the semi - final of Euro 2012.His father named him Kepler Laveran in honor to scientists Johannes Kepler and Charles Louis Alphonse Laveran.",
                    NationFK =7 },
                new Players {ID=11, Name="Rúben Dias", Image="RubenDias.jpg", Position="Defender",
                    Introduction="Rúben Santos Gato Alves Dias, born 14 May 1997, is a Portuguese professional footballer who plays for Benfica as a defender.",
                    NationFK =7 },
                new Players {ID=12, Name="Adrien Silva", Image="AdrienSilva.jpg", Position="Midfielder",
                    Introduction="Adrien Sébastien Perruchet da Silva, born 15 March 1989, known as Adrien Silva, is a Portuguese professional footballer who plays for English club Leicester City and the Portugal national team as a central midfielder." +
                    "He played mostly for Sporting since making his first - team debut at the age of 18, and was loaned to Maccabi Haifa and Académica, winning the Taça de Portugal with the latter in addition to the same honour at Sporting; with his main club, he appeared in 237 competitive games and scored 39 goals." +
                    "Known for his dribbling and passing qualities, Silva earned 46 caps for Portugal all youth categories comprised, including 13 for the under-21 team.He made his senior debut in 2014, and represented the nation at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=13, Name="Bruno Fernandes", Image="BrunoFernandes.jpg", Position="Midfielder",
                    Introduction="Bruno Miguel Borges Fernandes, born 8 September 1994, is a Portuguese footballer who plays for Sporting CP as a midfielder." +
                    "He spent most of his professional career in Italy, amassing Serie A totals of 119 games and 15 goals in representation of Udinese and Sampdoria.",
                    NationFK =7 },
                new Players {ID=14, Name="Manuel Fernandes", Image="ManuelFernandes.jpg", Position="Midfielder",
                    Introduction="Manuel Henrique Tavares Fernandes,born 5 February 1986, is a Portuguese professional footballer who plays for Russian club FC Lokomotiv Moscow as a midfielder." +
                    "He started his professional career with Benfica at only 18, then went on to compete in England and Spain, mainly at the service of Everton and Valencia. He signed with Be?ikta? in January 2011, spending the following three-and-a-half seasons with the club before joining Lokomotiv Moscow." +
                    "Fernandes represented the Portugal under-21 team in two European Championships. He made his debut with the full side in 2005.",
                    NationFK =7 },
                new Players {ID=15, Name="João Mário", Image="JoaoMario.jpg", Position="Midfielder",
                    Introduction="João Mário Naval da Costa Eduardo, born 19 January 1993, is a Portuguese professional footballer who plays for English club West Ham United on loan from Internazionale, and the Portugal national team, as a midfielder." +
                    "He started out at Sporting CP in whose youth system he developed, being loaned to Vitória de Setúbal in 2014 and subsequently returning to be an important part of the squads that won major trophies, including the 2015 Portuguese Cup." +
                    "João Mário made his senior debut for Portugal in 2014.He appeared for the nation at Euro 2016, winning the tournament.",
                    NationFK =7 },
                new Players {ID=16, Name="João Moutinho", Image="JoaoMoutinho.jpg", Position="Midfielder",
                    Introduction="João Filipe Iria Santos Moutinho, born 8 September 1986, is a Portuguese footballer who plays for AS Monaco FC and the Portugal national team. Mainly a central midfielder he can also operate as a defensive or attacking midfielder, and on either flank." +
                    "He started his professional career with Sporting, moving in 2010 to Porto and winning 12 major titles between the two clubs combined. Three years later, he transferred to Monaco for €25 million." +
                    "Moutinho represented the Portuguese national team at three European Championships and the 2014 World Cup, winning the 2016 edition of the former tournament.",
                    NationFK =7 },
                new Players {ID=17, Name="William Carvalho", Image="WilliamCarvalho.jpg", Position="Midfielder",
                    Introduction="William Silva de Carvalho, born 7 April 1992, is a Portuguese professional footballer who plays for Sporting CP and the Portugal national team as a defensive midfielder." +
                    "He spent most of his career with Sporting since making his debut with the first team at the age of 18, going on to appear in 188 competitive games and win the 2015 Portuguese Cup." +
                    "A full international for Portugal since 2013, Carvalho represented the nation at the 2014 World Cup and Euro 2016, winning the latter tournament.",
                    NationFK =7 },
                new Players {ID=18, Name="Bernardo Silva", Image="BernardoSilva.jpg", Position="Forward",
                    Introduction="Bernardo Mota Veiga de Carvalho e Silva, born 10 August 1994, is a Portuguese professional footballer who plays for English club Manchester City and the Portugal national team as a midfielder.",
                    NationFK =7 },
                new Players {ID=19, Name="Gelson Martins", Image="GelsonMartins.jpg", Position="Forward",
                    Introduction="Gelson Dany Batalha Martins, born 11 May 1995, is a Portuguese professional footballer who plays for Sporting CP and the Portugal national team as a winger.",
                    NationFK =7 },
                new Players {ID=20, Name="Gonçalo Guedes", Image="GoncaloGuedes.jpg", Position="Forward",
                    Introduction="Gonçalo Manuel Ganchinho Guedes, born 29 November 1996, is a Portuguese professional footballer who plays for Spanish club Valencia CF on loan from Paris Saint-Germain as a winger." +
                    "He began his career at Benfica, making his professional debut for the reserves in April 2014 and the first team six months later.After 11 goals in 63 games across all competitions, winning five major trophies, he transferred to Paris Saint - Germain for a fee of €30 million in January 2017." +
                    "Guedes has earned over 50 caps for Portugal at youth level, from under-15 to under - 23.He made his senior international debut in November 2015, at the age of 18.",
                    NationFK =7 },
                new Players {ID=21, Name="Ricardo Quaresma", Image="RicardoQuaresma.jpg", Position="Forward",
                    Introduction="Ricardo Andrade Quaresma Bernardo, born 26 September 1983, is a Portuguese professional footballer who plays as a winger for Turkish club Be?ikta? and the Portugal national team." +
                    "Quaresma began his career at Sporting CP, and has also played for Barcelona, Inter Milan, Chelsea, Be?ikta? and Al - Ahli Dubai, however he spent the best years of his career at Porto. He is popular for incorporating a repertoire of tricks into his style of play, including the rabona and trivela. A winger who can play on either flank, his qualities of speed and finesse cause a regular problem for opposing defenses." +
                    "A full international since 2003, Quaresma has over 70 caps for Portugal and represented them at three European Championships, including his nation's victorious campaign at UEFA Euro 2016, also reaching the semi-finals at Euro 2012.",
                    NationFK =7 },
                new Players {ID=22, Name="André Silva", Image="AndreSilva.jpg", Position="Forward",
                    Introduction="André Miguel Valente da Silva, born 6 November 1995, is a Portuguese professional footballer who plays as a striker for Italian club A.C. Milan and the Portugal national team." +
                    "An academy graduate of Porto, he impressed during his time with the reserve side before making his debut with the first team in 2015. He ultimately made over 50 appearances for the club, scoring 24 goals before joining Milan in 2017." +
                    "Silva represented Portugal at various youth levels, and was part of the squad which came second at the 2014 European Under - 19 Championship.His senior international debut followed two years later, and he featured at the 2017 Confederations Cup where his team came third.",
                    NationFK =7 },
                new Players {ID=23, Name="Cristiano Ronaldo", Image="CristianoRonaldo.jpg", Position="Forward",
                    Introduction ="Cristiano Ronaldo dos Santos Aveiro , born 5 February 1985, is a Portuguese professional footballer who plays as a forward for Spanish club Real Madrid and the Portugal national team. Often considered the best player in the world and widely regarded as one of the greatest of all time, Ronaldo has a record-tying five Ballon d'Or awards, the most for a European player, and is the first player to win four European Golden Shoes. He has won 25 trophies in his career, including five league titles, four UEFA Champions League titles and one UEFA European Championship. Both a prolific goalscorer and playmaker, Ronaldo holds the records for most official goals scored in Europe's top-five leagues, the UEFA Champions League, the UEFA European Championship, as well as those for most assists in the UEFA Champions League and the UEFA European Championship. He has scored over 650 senior career goals for club and country." +
                    "Born and raised on the Portuguese island of Madeira, Ronaldo was diagnosed with a racing heart at age 15. He underwent an operation to treat his condition, and began his senior club career playing for Sporting CP, before signing with Manchester United at age 18 in 2003. After winning his first trophy, the FA Cup, during his first season in England, he helped United win three successive Premier League titles, a UEFA Champions League title, and a FIFA Club World Cup. By age 22, he had received Ballon d'Or and FIFA World Player of the Year nominations and at age 23, he won his first Ballon d'Or and FIFA World Player of the Year awards. In 2009, Ronaldo was the subject of the most expensive association football transfer when he moved from Manchester United to Real Madrid in a transfer worth €94 million." +
                    "In Spain, Ronaldo has won 14 trophies, including two La Liga titles, two Copas del Rey, three UEFA Champions League titles, two UEFA Super Cups, and three FIFA Club World Cups.After joining Real Madrid, Ronaldo finished runner - up for the Ballon d'Or three times, behind Lionel Messi, his perceived career rival, before winning back-to-back Ballons d'Or in 2013 and 2014. Real Madrid's all-time leading goalscorer, Ronaldo has scored a record 34 La Liga hat-tricks, including a record-tying eight hat-tricks in the 2014–15 season and is the only player to reach 30 league goals in six consecutive La Liga seasons. Ronaldo won back-to-back Ballons d'Or for a second time, winning by a record voting margin in 2016 after sealing La Undécima, Madrid's 11th European title, and winning Euro 2016, and in 2017 after firing Madrid to the first back-to-back UEFA Champions League victory in history." +
                    "A Portuguese international, Ronaldo was named the best Portuguese player of all time by the Portuguese Football Federation in 2015.Ronaldo made his senior international debut in August 2003, at age 18.He is Portugal's most capped player of all time with over 140 caps, and has participated in seven major tournaments. He is Portugal's all - time top goalscorer.He scored his first international goal at Euro 2004 and helped Portugal reach the final. He took over full captaincy in July 2008, leading Portugal to their first - ever triumph in a major tournament by winning Euro 2016, and received the Silver Boot as the second - highest goalscorer of the tournament. One of the most marketable sportsmen, he was ranked the world's highest-paid athlete by Forbes in 2016 and 2017, as well as the world's most famous athlete by ESPN in 2016 and 2017.",
                    NationFK =7 },

            };
            players.ForEach(aa => context.Players.AddOrUpdate(a => a.Name, aa));
            context.SaveChanges();


        }
    }
}
