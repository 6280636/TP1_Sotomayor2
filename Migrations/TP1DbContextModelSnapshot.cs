﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP1_Sotomayor.Models.Data;

#nullable disable

namespace TP1_Sotomayor.Migrations
{
    [DbContext(typeof(TP1DbContext))]
    partial class TP1DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TP1_Sotomayor.Models.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<string>("ImgFile")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Equipe");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Le Futbol Club Barcelona, communément appelé FC Barcelone (diminutif Barça), est un club de football espagnol fondé en 1899.",
                            ImgFile = "/Images/BB.png",
                            Logo = "/Images/th.jpg",
                            Nom = "Barcelona"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Le Real Madrid Club de Fútbol, plus connu sous le nom de Real Madrid ou simplement Real.",
                            ImgFile = "/Images/RM.png",
                            Logo = "/Images/th.jpg",
                            Nom = "Real Madrid"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Le Club Atlético de Madrid S.A.D, plus couramment appelé Atlético de Madrid.",
                            ImgFile = "/Images/AM.png",
                            Logo = "/Images/th.jpg",
                            Nom = "Atletico Madrid"
                        });
                });

            modelBuilder.Entity("TP1_Sotomayor.Models.Joueur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Buts")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<int>("EquipeId")
                        .HasColumnType("int");

                    b.Property<string>("ImgFile")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("EquipeId");

                    b.ToTable("Joueurs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 39,
                            Buts = 474,
                            Description = "Lionel Messi, parfois surnommé Leo Messi, né le 24 juin 1987 à Rosario en Argentine, est un footballeur international argentin jouant au poste d'attaquant à l’Inter Miami CF en MLS. Octuple vainqueur du Ballon d'or, un record, il est considéré comme l'un des meilleurs joueurs de football toutes générations confondues. Messi commence le football dans sa ville natale de Rosario en Argentine. Dès son plus jeune âge, il a montré un talent exceptionnel pour le football. Il a commencé à jouer dès l'âge de cinq ans dans le club local de sa ville natale. Atteint d'un problème de croissance qui nécessite un traitement hormonal, il rejoint à treize ans le FC Barcelone, en Espagne.",
                            EquipeId = 1,
                            ImgFile = "/Images/mesipet.png",
                            Nom = "L. Messi"
                        },
                        new
                        {
                            Id = 2,
                            Age = 39,
                            Buts = 474,
                            Description = "Cristiano Ronaldo dos Santos Aveiro, couramment appelé Cristiano Ronaldo ou Ronaldo et surnommé CR7, né le 5 février 1985 à Funchal (Portugal), est un footballeur international portugais qui joue au poste d'attaquant au Al-Nassr FC.\r\n\r\nConsidéré comme l'un des meilleurs footballeurs de l'histoire, il est avec Lionel Messi (avec qui une rivalité sportive est entretenue) l’un des deux seuls à avoir remporté le Ballon d'or au moins cinq fois. Auteur de plus de 870 buts en plus de 1 200 matchs en carrière, Cristiano Ronaldo est le meilleur buteur de l'histoire du football selon la Fédération internationale de football association (FIFA). Il est également le meilleur buteur de la Ligue des champions de l'UEFA, des coupes d'Europe, du Real Madrid, du derby madrilène, de la Coupe du monde des clubs de la FIFA et de la sélection portugaise, dont il est le capitaine officiel depuis 2008. Premier joueur à avoir remporté le Soulier d'or européen à quatre reprises, il est également le meilleur buteur de l'histoire du championnat d'Europe des nations (avec 14 buts) devant Michel Platini et détient le record de buts en équipe nationale, avec 128 réalisations.",
                            EquipeId = 2,
                            ImgFile = "/Images/Ronaldopet.png",
                            Nom = "C. Ronaldo"
                        },
                        new
                        {
                            Id = 3,
                            Age = 39,
                            Buts = 474,
                            Description = "Antoine Griezmann (prononcer : [ɡʁjɛzman]4), surnommé « Grizi » ou « Grizou » par ses coéquipiers et supporters, né le 21 mars 1991 à Mâcon, est un footballeur international français jouant au poste d'attaquant ou milieu offensif à l'Atlético de Madrid.\r\n\r\nRecruté par la Real Sociedad à l'âge de quatorze ans, Griezmann est l'un des rares internationaux français formés à l'étranger. Il fait ses débuts professionnels avec le club basque et découvre le championnat d'Espagne à partir de 2010. Quatre ans plus tard, il est recruté par l'Atlético de Madrid et devient un des plus brillants acteurs de la Liga dont il sera désigné meilleur joueur du championnat en 2016. Cette même année, il atteint la finale de la Ligue des champions (où il rate un penalty) puis remporte la Ligue Europa 2018 en marquant deux buts en finale face à l'Olympique de Marseille. Il est nommé par la suite meilleur joueur de cette compétition.",
                            EquipeId = 3,
                            ImgFile = "/Images/griezmapet.png",
                            Nom = "Antoine"
                        },
                        new
                        {
                            Id = 4,
                            Age = 39,
                            Buts = 474,
                            Description = "Ronaldo de Assis Moreira, né le 21 mars 1980 à Porto Alegre au Brésil, plus communément connu sous le pseudonyme de Ronaldinho Gaúcho ou tout simplement Ronaldinho3, est un footballeur international brésilien. Il est champion du monde en 2002 avec l'équipe du Brésil.\r\n\r\nConsidéré comme un joueur atypique, Ronaldinho s'est réellement imposé en Europe en tant qu'ailier gauche, avec ses dribbles hors du commun, sa conduite de balle incroyable et son aisance sur coups francs. Ces qualités lui ont valu d'apparaître dans le FIFA 100, de remporter le prix du meilleur footballeur de l'année FIFA (2004 et 2005), le Ballon d'or 2005, le prix du meilleur joueur FIFPro (2005 et 2006), mais aussi le ballon d'Or brésilien en 2012. En 2009, il est élu joueur de la décennie4. Ronaldinho est considéré comme l'un des meilleurs joueurs de football brésilien avec Pelé, Ronaldo, Neymar, mais aussi l'un des plus grands joueurs de tous les temps.",
                            EquipeId = 1,
                            ImgFile = "/Images/Ronaldinhopet.png",
                            Nom = "R. Gaucho"
                        },
                        new
                        {
                            Id = 5,
                            Age = 39,
                            Buts = 474,
                            Description = "Luka Modrić, né le 9 septembre 1985 à Zadar en Croatie, est un footballeur international croate qui évolue au poste de milieu de terrain au Real Madrid.\r\n\r\nIl fait partie, avec Davor Šuker et Bernard Vukas, des plus grands joueurs croates de tous les temps. De surcroît, il est considéré comme l'un des plus grands milieux de terrain de l'histoire du football2,3,4. Il commence au Dinamo Zagreb en 2003, élu meilleur espoir croate en 2004, il devient un joueur phare du championnat de Croatie qu'il remporte trois fois d'affilée de 2006 à 2008 avant de s'envoler vers le Tottenham Hotspur fin 2008 où il deviendra l'un des milieux les plus reconnus de Premier League.",
                            EquipeId = 2,
                            ImgFile = "/Images/Modrichpet.png",
                            Nom = "L. Modric"
                        },
                        new
                        {
                            Id = 6,
                            Age = 39,
                            Buts = 474,
                            Description = "Jan Oblak, né le 7 janvier 1993 à Škofja Loka en Slovénie, est un footballeur international slovène qui évolue au poste de gardien de but à l'Atlético de Madrid.\r\n\r\nIl débarque à l'Atlético en 2014 avec lequel il est finaliste de la Ligue des champions en 2016 contre le Real Madrid. Deux ans plus tard, Oblak remporte la Ligue Europa en réussissant le clean sheet contre l'Olympique de Marseille en finale (3-0). La même année, il remporte la Supercoupe de l'UEFA contre le Real Madrid et finit vice-champion d'Espagne derrière le Barça.Il remporte LaLiga en 2021 en finissant meilleur joueur de la saison",
                            EquipeId = 3,
                            ImgFile = "/Images/Janpet.png",
                            Nom = "J. Oblak"
                        },
                        new
                        {
                            Id = 7,
                            Age = 43,
                            Buts = 323,
                            Description = "Samuel Eto'o Fils, plus connu sous le nom Samuel Eto'o né le 10 mars 1981 à Nkon à Yaoundé au Cameroun, est un footballeur international camerounais. Durant sa carrière, il évolue au poste d'attaquant. Il possède également la nationalité espagnole depuis 2007.\r\n\r\nIl est président de la Fédération camerounaise de football (FECAFOOT) depuis décembre 2021.",
                            EquipeId = 1,
                            ImgFile = "/Images/etoopet.png",
                            Nom = "Eto'o"
                        },
                        new
                        {
                            Id = 8,
                            Age = 39,
                            Buts = 474,
                            Description = "Cristiano Ronaldo dos Santos Aveiro, couramment appelé Cristiano Ronaldo ou Ronaldo et surnommé CR7, né le 5 février 1985 à Funchal (Portugal), est un footballeur international portugais qui joue au poste d'attaquant au Al-Nassr FC.\r\n\r\nConsidéré comme l'un des meilleurs footballeurs de l'histoire, il est avec Lionel Messi (avec qui une rivalité sportive est entretenue) l’un des deux seuls à avoir remporté le Ballon d'or au moins cinq fois. Auteur de plus de 870 buts en plus de 1 200 matchs en carrière, Cristiano Ronaldo est le meilleur buteur de l'histoire du football selon la Fédération internationale de football association (FIFA). Il est également le meilleur buteur de la Ligue des champions de l'UEFA, des coupes d'Europe, du Real Madrid, du derby madrilène, de la Coupe du monde des clubs de la FIFA et de la sélection portugaise, dont il est le capitaine officiel depuis 2008. Premier joueur à avoir remporté le Soulier d'or européen à quatre reprises, il est également le meilleur buteur de l'histoire du championnat d'Europe des nations (avec 14 buts) devant Michel Platini et détient le record de buts en équipe nationale, avec 128 réalisations.",
                            EquipeId = 2,
                            ImgFile = "/Images/ronaldobrasil.png",
                            Nom = "Ronaldo"
                        },
                        new
                        {
                            Id = 9,
                            Age = 39,
                            Buts = 474,
                            Description = "Antoine Griezmann (prononcer : [ɡʁjɛzman]4), surnommé « Grizi » ou « Grizou » par ses coéquipiers et supporters, né le 21 mars 1991 à Mâcon, est un footballeur international français jouant au poste d'attaquant ou milieu offensif à l'Atlético de Madrid.\r\n\r\nRecruté par la Real Sociedad à l'âge de quatorze ans, Griezmann est l'un des rares internationaux français formés à l'étranger. Il fait ses débuts professionnels avec le club basque et découvre le championnat d'Espagne à partir de 2010. Quatre ans plus tard, il est recruté par l'Atlético de Madrid et devient un des plus brillants acteurs de la Liga dont il sera désigné meilleur joueur du championnat en 2016. Cette même année, il atteint la finale de la Ligue des champions (où il rate un penalty) puis remporte la Ligue Europa 2018 en marquant deux buts en finale face à l'Olympique de Marseille. Il est nommé par la suite meilleur joueur de cette compétition.",
                            EquipeId = 3,
                            ImgFile = "/Images/depoolpet.png",
                            Nom = "DePool"
                        },
                        new
                        {
                            Id = 10,
                            Age = 39,
                            Buts = 474,
                            Description = "Ronaldo de Assis Moreira, né le 21 mars 1980 à Porto Alegre au Brésil, plus communément connu sous le pseudonyme de Ronaldinho Gaúcho ou tout simplement Ronaldinho3, est un footballeur international brésilien. Il est champion du monde en 2002 avec l'équipe du Brésil.\r\n\r\nConsidéré comme un joueur atypique, Ronaldinho s'est réellement imposé en Europe en tant qu'ailier gauche, avec ses dribbles hors du commun, sa conduite de balle incroyable et son aisance sur coups francs. Ces qualités lui ont valu d'apparaître dans le FIFA 100, de remporter le prix du meilleur footballeur de l'année FIFA (2004 et 2005), le Ballon d'or 2005, le prix du meilleur joueur FIFPro (2005 et 2006), mais aussi le ballon d'Or brésilien en 2012. En 2009, il est élu joueur de la décennie4. Ronaldinho est considéré comme l'un des meilleurs joueurs de football brésilien avec Pelé, Ronaldo, Neymar, mais aussi l'un des plus grands joueurs de tous les temps.",
                            EquipeId = 1,
                            ImgFile = "/Images/iniestapetit.png",
                            Nom = "Iniesta"
                        },
                        new
                        {
                            Id = 11,
                            Age = 39,
                            Buts = 474,
                            Description = "Luka Modrić, né le 9 septembre 1985 à Zadar en Croatie, est un footballeur international croate qui évolue au poste de milieu de terrain au Real Madrid.\r\n\r\nIl fait partie, avec Davor Šuker et Bernard Vukas, des plus grands joueurs croates de tous les temps. De surcroît, il est considéré comme l'un des plus grands milieux de terrain de l'histoire du football2,3,4. Il commence au Dinamo Zagreb en 2003, élu meilleur espoir croate en 2004, il devient un joueur phare du championnat de Croatie qu'il remporte trois fois d'affilée de 2006 à 2008 avant de s'envoler vers le Tottenham Hotspur fin 2008 où il deviendra l'un des milieux les plus reconnus de Premier League.",
                            EquipeId = 2,
                            ImgFile = "/Images/figopet.png",
                            Nom = "Figo"
                        },
                        new
                        {
                            Id = 12,
                            Age = 39,
                            Buts = 474,
                            Description = "Jan Oblak, né le 7 janvier 1993 à Škofja Loka en Slovénie, est un footballeur international slovène qui évolue au poste de gardien de but à l'Atlético de Madrid.\r\n\r\nIl débarque à l'Atlético en 2014 avec lequel il est finaliste de la Ligue des champions en 2016 contre le Real Madrid. Deux ans plus tard, Oblak remporte la Ligue Europa en réussissant le clean sheet contre l'Olympique de Marseille en finale (3-0). La même année, il remporte la Supercoupe de l'UEFA contre le Real Madrid et finit vice-champion d'Espagne derrière le Barça.Il remporte LaLiga en 2021 en finissant meilleur joueur de la saison",
                            EquipeId = 3,
                            ImgFile = "/Images/forlanpet.png",
                            Nom = "Forlan"
                        });
                });

            modelBuilder.Entity("TP1_Sotomayor.Models.Joueur", b =>
                {
                    b.HasOne("TP1_Sotomayor.Models.Equipe", "Equipe")
                        .WithMany("Joueurs")
                        .HasForeignKey("EquipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("TP1_Sotomayor.Models.Equipe", b =>
                {
                    b.Navigation("Joueurs");
                });
#pragma warning restore 612, 618
        }
    }
}
