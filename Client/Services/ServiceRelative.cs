using System;
using System.Collections.Generic;
using Home2Med.Shared.Entity;

namespace Home2Med.Client.Services
{
    public class ServiceRelative : IServiceRelative
    {
        public List<Relative> GetRelatives()
        {
            return new List<Relative>()
            {
                new Relative()
                {
                    Id = 1,
                    RelativeName = "Gerardo Piedras",
                    RelativeDocumentType = 1,
                    RelativeDocument = "12345689",
                    RelativeGender = 2,
                    RelativePhone = "3104789632",
                    RelativeRelationship = 8,
                    RelativeEmail = "gerardopiedras1@gmail.com",
                    RelativePatientDoc = "1015423021",
                    RelativePhoto = "/Images/familiares/fotof01.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 2,
                    RelativeName = "Esther Correa",
                    RelativeDocumentType = 1,
                    RelativeDocument = "1365452",
                    RelativeGender = 2,
                    RelativePhone = "31065894226",
                    RelativeRelationship = 1,
                    RelativeEmail = "esthercorrea1@gmail.com",
                    RelativePatientDoc = "1025641221",
                    RelativePhoto = "/Images/familiares/fotof02.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 3,
                    RelativeName = "Patricia Romero",
                    RelativeDocumentType = 3,
                    RelativeDocument = "36594852",
                    RelativeGender = 2,
                    RelativePhone = "3115428469",
                    RelativeRelationship = 1,
                    RelativeEmail = "particiaromero1@gmail.com",
                    RelativePatientDoc = "1025641221",
                    RelativePhoto = "/Images/familiares/fotof03.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 4,
                    RelativeName = "Petra Contreras",
                    RelativeDocumentType = 1,
                    RelativeDocument = "11125468",
                    RelativeGender = 1,
                    RelativePhone = "3125789632",
                    RelativeRelationship = 3,
                    RelativeEmail = "petracontreras1@gmail.com",
                    RelativePatientDoc = "1025641221",
                    RelativePhoto = "/Images/familiares/fotof04.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 5,
                    RelativeName = "Roberto Pérez",
                    RelativeDocumentType = 1,
                    RelativeDocument = "1015423015",
                    RelativeGender = 1,
                    RelativePhone = "3104768542",
                    RelativeRelationship = 1,
                    RelativeEmail = "robertoperez1@gmail.com",
                    RelativePatientDoc = "1025636521",
                    RelativePhoto = "/Images/familiares/fotof05.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 6,
                    RelativeName = "Camila Peralta",
                    RelativeDocumentType = 1,
                    RelativeDocument = "20568354",
                    RelativeGender = 2,
                    RelativePhone = "31269854758",
                    RelativeRelationship = 8,
                    RelativeEmail = "camilaperalta1@gmail.com",
                    RelativePatientDoc = "1026556421",
                    RelativePhoto = "/Images/familiares/fotof06.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 7,
                    RelativeName = "Marcela Segura",
                    RelativeDocumentType = 1,
                    RelativeDocument = "16358942",
                    RelativeGender = 1,
                    RelativePhone = "3165849632",
                    RelativeRelationship = 5,
                    RelativeEmail = "marcelasegura1@gmail.com",
                    RelativePatientDoc = "2025641221",
                    RelativePhoto = "/Images/familiares/fotof07.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 8,
                    RelativeName = "Pedro González Neira",
                    RelativeDocumentType = 2,
                    RelativeDocument = "635894",
                    RelativeGender = 1,
                    RelativePhone = "31425648596",
                    RelativeRelationship =3,
                    RelativeEmail = "pedrogonzalezneira1@gmail.com",
                    RelativePatientDoc = "3025641221",
                    RelativePhoto = "/Images/familiares/fotof08.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 9,
                    RelativeName = "Arturo Sanchez",
                    RelativeDocumentType = 1,
                    RelativeDocument = "658452254",
                    RelativeGender = 2,
                    RelativePhone = "3104789782",
                    RelativeRelationship = 2,
                    RelativeEmail = "arturosanchez1@gmail.com",
                    RelativePatientDoc = "5025641221",
                    RelativePhoto = "/Images/familiares/fotof09.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 10,
                    RelativeName = "Andrés Cochise",
                    RelativeDocumentType = 1,
                    RelativeDocument = "12658489",
                    RelativeGender = 2,
                    RelativeRelationship = 7,
                    RelativeEmail = "andrescochise1@gmail.com",
                    RelativePatientDoc = "1025641221",
                    RelativePhoto = "/Images/familiares/fotof10.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 11,
                    RelativeName = "Andrey Pérez",
                    RelativeDocumentType = 3,
                    RelativeDocument = "125487",
                    RelativeGender = 2,
                    RelativePhone = "316539632",
                    RelativeRelationship = 8,
                    RelativeEmail = "andreyperez1@gmail.com",
                    RelativePatientDoc = "1063251221",
                    RelativePhoto = "/Images/familiares/fotof11.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 12,
                    RelativeName = "Camila Basto",
                    RelativeDocumentType = 1,
                    RelativeDocument = "12635689",
                    RelativeGender = 1,
                    RelativePhone = "3104789632",
                    RelativeRelationship = 2,
                    RelativeEmail = "camilabasto1@gmail.com",
                    RelativePatientDoc = "1063241221",
                    RelativePhoto = "/Images/familiares/fotof12.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 13,
                    RelativeName = "Anton González",
                    RelativeDocumentType = 1,
                    RelativeDocument = "658542169",
                    RelativeGender = 1,
                    RelativePhone = "3125358564",
                    RelativeRelationship = 1,
                    RelativeEmail = "antongonzalez1@gmail.com",
                    RelativePatientDoc = "4025641221",
                    RelativePhoto = "/Images/familiares/fotof13.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 14,
                    RelativeName = "Camila Contreras",
                    RelativeDocumentType = 1,
                    RelativeDocument = "163521689",
                    RelativeGender = 1,
                    RelativePhone = "314526358",
                    RelativeRelationship = 8,
                    RelativeEmail = "camilacontreras1@gmail.com",
                    RelativePatientDoc = "1025646521",
                    RelativePhoto = "/Images/familiares/fotof14.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 15,
                    RelativeName = "Lorena Suárez Jamoque",
                    RelativeDocumentType = 2,
                    RelativeDocument = "3652419",
                    RelativeGender = 1,
                    RelativePhone = "3104799632",
                    RelativeRelationship = 5,
                    RelativeEmail = "lorenasuarezjamoque1@gmail.com",
                    RelativePatientDoc = "1115641221",
                    RelativePhoto = "/Images/familiares/fotof15.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 16,
                    RelativeName = "Camila Gaviria",
                    RelativeDocumentType = 2,
                    RelativeDocument = "1064561",
                    RelativeGender = 2,
                    RelativePhone = "3123789632",
                    RelativeRelationship = 7,
                    RelativeEmail = "camilagaviria1@gmail.com",
                    RelativePatientDoc = "2028641221",
                    RelativePhoto = "/Images/familiares/fotof16.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 17,
                    RelativeName = "Ernesto Herrera",
                    RelativeDocumentType = 1,
                    RelativeDocument = "1014874521",
                    RelativeGender = 2,
                    RelativePhone = "3115956547",
                    RelativeRelationship = 3,
                    RelativeEmail = "ernestoherrera1@gmail.com",
                    RelativePatientDoc = "205678455",
                    RelativePhoto = "/Images/familiares/fotof17.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 18,
                    RelativeName = "Sofía Ruiz",
                    RelativeDocumentType = 1,
                    RelativeDocument = "163251689",
                    RelativeGender = 2,
                    RelativePhone = "3012487546",
                    RelativeRelationship = 8,
                    RelativeEmail = "sofiaruiz1@gmail.com",
                    RelativePatientDoc = "2025644221",
                    RelativePhoto = "/Images/familiares/fotof18.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 19,
                    RelativeName = "Claudia Mejía",
                    RelativeDocumentType = 3,
                    RelativeDocument = "3654159",
                    RelativeGender = 1,
                    RelativePhone = "3185241645",
                    RelativeRelationship = 3,
                    RelativeEmail = "claudiamejia1@gmail.com",
                    RelativePatientDoc = "2325641221",
                    RelativePhoto = "/Images/familiares/fotof19.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 20,
                    RelativeName = "Antonia Peñuela",
                    RelativeDocumentType = 1,
                    RelativeDocument = "1018410356",
                    RelativeGender = 1,
                    RelativePhone = "3135258469",
                    RelativeRelationship = 2,
                    RelativeEmail = "antoniapenuela1@gmail.com",
                    RelativePatientDoc = "1325641221",
                    RelativePhoto = "/Images/familiares/fotof20.jpg",
                    RelativeStatus = true
                },
                new Relative()
                {
                    Id = 21,
                    RelativeName = "Gregorio Ocampo",
                    RelativeDocumentType = 2,
                    RelativeDocument = "3654218",
                    RelativeGender = 1,
                    RelativePhone = "3102656325",
                    RelativeRelationship = 5,
                    RelativeEmail = "gregorioocampo1@gmail.com",
                    RelativePatientDoc = "3025641221",
                    RelativePhoto = "/Images/familiares/fotof21.jpg",
                    RelativeStatus = true
                }
            };
        }
    }
}