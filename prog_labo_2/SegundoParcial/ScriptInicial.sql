CREATE DATABASE  [ClinicaUtn]
GO
/****** Object:  Table [dbo].[Especialistas]    Script Date: 18/06/2020 07:02:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Use [ClinicaUtn]
go
CREATE TABLE [dbo].[Especialistas](
	[idEspecialista] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[edad] [int] NOT NULL,
	[sexo] [nvarchar](10) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[especialidad] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 18/06/2020 07:02:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[edad] [int] NOT NULL,
	[sexo] [nvarchar](10) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[obraSocial] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 18/06/2020 07:02:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[idTurno] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NOT NULL,
	[idEspecialista] [int] NOT NULL,
	[observacionesTurno] [nvarchar](max) NOT NULL,
	[fechaTurno] [nvarchar](20) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


insert into Especialistas values ('Purry','Winonah',27,'femenino','70981 Ruskin Center', 'Psicologia');						
insert into Especialistas values ('Newbury','Nicol',46,'masculino','1259 Dennis Park', 'Psicologia');						
insert into Especialistas values ('Vassbender','Deana',30,'femenino','549 3rd Junction', 'Psicologia');						
insert into Especialistas values ('Scandrett','Simonette',24,'femenino','623 Schlimgen Alley', 'Psicologia');						
insert into Especialistas values ('Wisby','Nichole',31,'masculino','08258 Fieldstone Lane', 'Psicologia');						
insert into Especialistas values ('Baylie','Sallie',41,'femenino','1295 Mccormick Avenue', 'Psicologia');						
insert into Especialistas values ('Farraway','Elden',53,'masculino','82 Ilene Crossing', 'Psicologia');						 
insert into Especialistas values ('Tofano','Constantine',27,'masculino','3 Village Green Lane', 'Dermatologia');						
insert into Especialistas values ('Eggerton','Germaine',32,'masculino','21503 Roth Trail', 'Dermatologia');						
insert into Especialistas values ('Fenner','Felisha',38,'femenino','7796 Old Gate Alley', 'Dermatologia');						
insert into Especialistas values ('Tennick','Marquita',51,'femenino','32 Dorton Point', 'Dermatologia');						
insert into Especialistas values ('Lauritzen','Verney',24,'masculino','263 5th Lane', 'Dermatologia');						
insert into Especialistas values ('Whittier','Freddi',35,'femenino','45717 Little Fleur Terrace', 'Dermatologia');						
insert into Especialistas values ('Habble','Kasper',26,'masculino','393 Straubel Alley', 'Dermatologia');						
insert into Especialistas values ('Escofier','Johnathon',39,'masculino','406 Derek Trail', 'Dermatologia');						
insert into Especialistas values ('Mitrikhin','Fifi',26,'femenino','055 Montana Trail', 'Dermatologia');						
insert into Especialistas values ('Holyland','Leighton',32,'masculino','05426 Browning Pass', 'Dermatologia');						
insert into Especialistas values ('Langhorn','Brinn',24,'femenino','55091 Badeau Court', 'Dermatologia');						
insert into Especialistas values ('Josovitz','Edsel',46,'masculino','826 Village Pass', 'Dermatologia');		
				
insert into Especialistas values ('Colcomb','Ringo',43,'masculino','826 Farragut Center', 'Otorrinolaringologia');						
insert into Especialistas values ('Bilyard','Lucky',58,'femenino','51 Di Loreto Hill', 'Otorrinolaringologia');						
insert into Especialistas values ('Voase','Delmar',50,'masculino','64 North Circle', 'Otorrinolaringologia');						
insert into Especialistas values ('Erb','Albert',47,'masculino','787 Maple Wood Avenue', 'Otorrinolaringologia');						
insert into Especialistas values ('Forsbey','Hermon',51,'masculino','54546 Maple Wood Center', 'Otorrinolaringologia');						
insert into Especialistas values ('Vannozzii','Shawn',39,'femenino','2308 Atwood Park', 'Otorrinolaringologia');						
insert into Especialistas values ('Ferrige','Abby',48,'masculino','4 Clove Way', 'Otorrinolaringologia');						
insert into Especialistas values ('MacPhee','Fransisco',20,'masculino','7577 Claremont Alley', 'Otorrinolaringologia');						
insert into Especialistas values ('Warlow','Daune',56,'femenino','07885 Esker Crossing', 'Otorrinolaringologia');						
insert into Especialistas values ('Easthope','Adan',49,'femenino','5 High Crossing Parkway', 'Otorrinolaringologia');						
insert into Especialistas values ('Aguirre','Donall',48,'masculino','502 Jay Place', 'Otorrinolaringologia');						
insert into Especialistas values ('Dunthorn','Othilie',55,'femenino','81 Barby Hill', 'Otorrinolaringologia');						
insert into Especialistas values ('Uc','Joby',58,'femenino','575 Lien Junction', 'Otorrinolaringologia');		
insert into Especialistas values ('Senton','Jeni',38,'femenino','98515 Elka Lane', 'Ginecologia');						
insert into Especialistas values ('Timbridge','Deina',52,'femenino','7 Sheridan Court', 'Ginecologia');						
insert into Especialistas values ('Drewes','Dave',53,'masculino','04680 Oneill Road', 'Ginecologia');						
insert into Especialistas values ('Jacketts','Datha',30,'femenino','0 Old Shore Parkway', 'Ginecologia');						
insert into Especialistas values ('Gussie','Giffard',53,'masculino','403 Thompson Avenue', 'Ginecologia');						
insert into Especialistas values ('Lyptratt','Marthe',58,'femenino','178 Duke Circle', 'Ginecologia');						
insert into Especialistas values ('Casassa','Edgard',38,'masculino','353 Gulseth Drive', 'Ginecologia');						
insert into Especialistas values ('Poat','Blinni',24,'femenino','1 Mayfield Park', 'Ginecologia');						
insert into Especialistas values ('Gerson','Vic',30,'masculino','3 Sloan Pass', 'Ginecologia');			
insert into Especialistas values ('Copestake','Maddie',36,'femenino','0680 Northland Plaza', 'Dermatologia');						
insert into Especialistas values ('Westover','Sterling',24,'masculino','01019 Northridge Drive', 'Dermatologia');						
insert into Especialistas values ('Oxford','Roseann',47,'femenino','17 Bowman Circle', 'Dermatologia');						
insert into Especialistas values ('Widdowson','Cherey',49,'femenino','7 Dexter Court', 'Dermatologia');						
insert into Especialistas values ('Collar','Zorina',60,'femenino','2 Pawling Park', 'Dermatologia');						
insert into Especialistas values ('Barr','Virgie',39,'masculino','5139 Annamark Place', 'Dermatologia');						
insert into Especialistas values ('Doole','Nanci',38,'femenino','5 Del Sol Point', 'Dermatologia');						
insert into Especialistas values ('Hacket','Rosalynd',57,'femenino','52155 Cherokee Drive', 'Dermatologia');						
insert into Especialistas values ('Bault','Jeannette',60,'femenino','409 Sugar Court', 'Dermatologia');						
insert into Especialistas values ('Drewell','Beverlie',35,'femenino','89608 Village Crossing', 'Dermatologia');						
insert into Especialistas values ('Atwool','Pattie',59,'femenino','28925 Butternut Place', 'Dermatologia');						
insert into Especialistas values ('Greenhouse','Clayson',31,'masculino','8519 Nelson Street', 'Dermatologia');						
insert into Especialistas values ('Yosifov','Lynelle',39,'femenino','5297 Fisk Way', 'Dermatologia');		
insert into Especialistas values ('Rhymer','Sheelah',40,'femenino','3 Superior Lane', 'Obtetricia');						
insert into Especialistas values ('Linsey','Erda',26,'femenino','0569 Bultman Avenue', 'Obtetricia');						
insert into Especialistas values ('Sorby','Rosamund',36,'femenino','6313 Briar Crest Hill', 'Obtetricia');						
insert into Especialistas values ('Spellacey','Tremaine',25,'masculino','17 Kenwood Center', 'Obtetricia');						
insert into Especialistas values ('Klimus','Carmelina',47,'femenino','92 Arrowood Avenue', 'Obtetricia');						
insert into Especialistas values ('Bogays','Jillian',34,'femenino','8 Pepper Wood Drive', 'Obtetricia');						
insert into Especialistas values ('Goodson','Jasen',28,'masculino','5 American Park', 'Obtetricia');						
insert into Especialistas values ('Mourge','Rogerio',27,'masculino','913 Arizona Alley', 'Obtetricia');						
insert into Especialistas values ('Jandourek','Austin',39,'masculino','2914 Porter Pass', 'Obtetricia');						
insert into Especialistas values ('Boggers','Ramsay',51,'masculino','72158 Waywood Junction', 'Obtetricia');						
insert into Especialistas values ('Crass','Audre',41,'femenino','7480 Pawling Park', 'Obtetricia');						
insert into Especialistas values ('Janodet','Dinnie',45,'femenino','7 Portage Alley', 'Obtetricia');						
insert into Especialistas values ('Heads','Lisetta',55,'femenino','5691 Memorial Terrace', 'Obtetricia');						
insert into Especialistas values ('Bowstead','Raymond',54,'masculino','11 Lunder Point', 'Obtetricia');						
insert into Especialistas values ('Edwicker','Kerk',41,'masculino','14837 Huxley Center', 'Obtetricia');						
insert into Especialistas values ('Gorick','Anderson',60,'masculino','788 Old Gate Avenue', 'Obtetricia');		
insert into Especialistas values ('Hagston','Fields',46,'masculino','0597 Merrick Terrace', 'Pediatria');						
insert into Especialistas values ('Askell','Ricky',26,'femenino','836 Texas Circle', 'Pediatria');						
insert into Especialistas values ('Skellorne','Karry',37,'femenino','502 Ridgeview Alley', 'Pediatria');						
insert into Especialistas values ('Cavan','Lynde',26,'femenino','660 Manitowish Place', 'Pediatria');						
insert into Especialistas values ('Wolstencroft','Aland',34,'masculino','4910 Warbler Parkway', 'Pediatria');						
insert into Especialistas values ('Hamlet','Kynthia',20,'femenino','46 Eliot Place', 'Pediatria');						
insert into Especialistas values ('Murison','Lorrin',20,'femenino','617 Corben Road', 'Pediatria');						
insert into Especialistas values ('Steckings','Renaldo',39,'masculino','53993 Briar Crest Plaza', 'Pediatria');						
insert into Especialistas values ('Kopec','Leonanie',20,'femenino','8 High Crossing Place', 'Pediatria');						
insert into Especialistas values ('Diemer','Merell',35,'masculino','0 Eastlawn Way', 'Pediatria');						
insert into Especialistas values ('Blyden','Keary',20,'masculino','55865 Truax Road', 'Pediatria');						
insert into Especialistas values ('Siveter','Corrinne',26,'femenino','08374 Jackson Drive', 'Pediatria');						
insert into Especialistas values ('Yes','Bobbie',60,'femenino','6 Carey Alley', 'Pediatria');						
insert into Especialistas values ('Wainscot','Doug',39,'masculino','17 West Center', 'Pediatria');						
insert into Especialistas values ('Ible','Vickie',28,'femenino','45026 Leroy Terrace', 'Pediatria');		
insert into Especialistas values ('Grabiec','Mikel',53,'masculino','3 Carey Plaza', 'ClinicaGeneral');						
insert into Especialistas values ('Millgate','Charles',35,'masculino','05 Morrow Terrace', 'ClinicaGeneral');						
insert into Especialistas values ('Belchem','Estrellita',39,'femenino','013 Caliangt Street', 'ClinicaGeneral');						
insert into Especialistas values ('Sextone','Vally',28,'femenino','10 Arapahoe Park', 'ClinicaGeneral');						
insert into Especialistas values ('Lorenzetti','Debby',54,'femenino','76 Sommers Trail', 'ClinicaGeneral');						
insert into Especialistas values ('MacDiarmid','Merle',53,'masculino','1766 Wayridge Terrace', 'Psicologia');						
insert into Especialistas values ('Sidebotham','Ardeen',28,'femenino','40 Kensington Plaza', 'ClinicaGeneral');						
insert into Especialistas values ('Pilgrim','Amelita',59,'femenino','83291 Armistice Alley', 'ClinicaGeneral');						
insert into Especialistas values ('Cadreman','Kati',24,'femenino','120 Summit Pass', 'ClinicaGeneral');						
insert into Especialistas values ('Hick','Almire',49,'femenino','076 Toban Drive', 'ClinicaGeneral');						
insert into Especialistas values ('Greenman','Fara',35,'femenino','115 Magdeline Point', 'ClinicaGeneral');						
insert into Especialistas values ('Reast','Farlay',39,'masculino','0 Kim Parkway', 'ClinicaGeneral');						
insert into Especialistas values ('MacMoyer','Rikki',39,'masculino','8 Haas Street', 'ClinicaGeneral');						 
insert into Especialistas values ('Durning','Riccardo',38,'masculino','5 Sauthoff Parkway', 'ClinicaGeneral');						
insert into Especialistas values ('Gossart','Nixie',38,'femenino','30 Vera Circle', 'ClinicaGeneral');						
insert into Especialistas values ('Ferreri','Fanni',26,'femenino','666 Westerfield Place', 'ClinicaGeneral');						
insert into Especialistas values ('Coopland','Christabel',24,'femenino','4 7th Road', 'ClinicaGeneral');						
insert into Especialistas values ('Rodman','Gretel',32,'femenino','88643 Redwing Trail', 'ClinicaGeneral');						
insert into Especialistas values ('Dunridge','Kimmi',33,'femenino','5 Basil Road', 'ClinicaGeneral');						
insert into Especialistas values ('Stiger','Angil',53,'femenino','73 Truax Center', 'ClinicaGeneral');						
insert into Especialistas values ('Cliff','Lauryn',35,'femenino','4399 Reindahl Avenue', 'ClinicaGeneral');						
insert into Especialistas values ('Kittles','Waldo',46,'masculino','995 Bartelt Pass', 'ClinicaGeneral');						
insert into Especialistas values ('Frankham','Charles',45,'masculino','06 Donald Way', 'ClinicaGeneral');						
insert into Especialistas values ('Gowen','Janenna',59,'femenino','25 Del Sol Center', 'ClinicaGeneral');						
insert into Especialistas values ('Tomaszewicz','Caitlin',57,'femenino','14179 Ohio Lane', 'Psicologia');		

insert into pacientes values('Laugheran', 'Marji', 32, 'Femenino', '9 Jana Crossing', 'CoberturaBasica');
insert into pacientes values('Adams', 'Sabra', 38, 'Femenino', '484 Veith Avenue', 'CoberturaBasica');
insert into pacientes values('Bellay', 'Carly', 39, 'Masculino', '23 Stang Court', 'CoberturaBasica');
insert into pacientes values('Isard', 'Eloise', 53, 'Femenino', '64 Bartillon Court', 'CoberturaBasica');
insert into pacientes values('Huggard', 'Constantina', 59, 'Femenino', '383 Sutherland Parkway', 'CoberturaBasica');
insert into pacientes values('Gotter', 'Marys', 50, 'Femenino', '55 Thackeray Plaza', 'CoberturaBasica');
insert into pacientes values('Harnott', 'Geneva', 51, 'Femenino', '631 Summit Court', 'CoberturaBasica');
insert into pacientes values('Winspeare', 'Wallis', 46, 'Femenino', '53802 Fordem Parkway', 'CoberturaBasica');
insert into pacientes values('Sherborn', 'Ainsley', 54, 'Femenino', '653 Artisan Circle', 'CoberturaBasica');
insert into pacientes values('Wyldes', 'Elijah', 17, 'Masculino', '4292 Alpine Junction', 'CoberturaBasica');
insert into pacientes values('Fihelly', 'Salomone', 58, 'Masculino', '3173 Transport Place', 'CoberturaBasica');
insert into pacientes values('Muro', 'Stacy', 37, 'Masculino', '99606 Hoepker Plaza', 'CoberturaBasica');
insert into pacientes values('Kunc', 'Inglis', 55, 'Masculino', '980 Milwaukee Hill', 'CoberturaBasica');
insert into pacientes values('Stapleford', 'Berkie', 59, 'Masculino', '11 Di Loreto Parkway', 'CoberturaBasica');
insert into pacientes values('Sunnex', 'Ruthann', 48, 'Femenino', '7438 Stephen Trail', 'CoberturaBasica');
insert into pacientes values('Elix', 'Karel', 15, 'Femenino', '187 Vernon Crossing', 'CoberturaBasica');
insert into pacientes values('Kassman', 'Mary', 41, 'Femenino', '1851 Oakridge Place', 'CoberturaBasica');
insert into pacientes values('Ivett', 'Leelah', 26, 'Femenino', '47536 Thierer Avenue', 'CoberturaBasica');
insert into pacientes values('Corben', 'Kath', 30, 'Femenino', '25669 Sachtjen Plaza', 'CoberturaBasica');
insert into pacientes values('Chalice', 'Adolpho', 46, 'Masculino', '47 Daystar Court', 'CoberturaBasica');
insert into pacientes values('Labern', 'Jammie', 55, 'Femenino', '35580 Dawn Trail', 'CoberturaBasica');
insert into pacientes values('Cathersides', 'Val', 40, 'Masculino', '3 Scott Terrace', 'CoberturaBasica');
insert into pacientes values('Doutch', 'Miguel', 29, 'Masculino', '8685 Pawling Court', 'CoberturaBasica');
insert into pacientes values('Raycroft', 'Laurena', 49, 'Femenino', '23641 Colorado Avenue', 'CoberturaBasica');
insert into pacientes values('Westover', 'Noll', 39, 'Masculino', '90 Kenwood Crossing', 'CoberturaBasica');
insert into pacientes values('De Freyne', 'Auroora', 20, 'Femenino', '3508 Upham Circle', 'CoberturaBasica');
insert into pacientes values('Rossoni', 'Holmes', 28, 'Masculino', '1 Duke Park', 'CoberturaBasica');
insert into pacientes values('Larby', 'Kathryne', 30, 'Femenino', '37 Bluestem Street', 'CoberturaBasica');
insert into pacientes values('McPhillimey', 'Heinrik', 16, 'Masculino', '861 Hagan Lane', 'CoberturaBasica');
insert into pacientes values('Gheeorghie', 'Catha', 58, 'Femenino', '0 Merchant Park', 'CoberturaBasica');
insert into pacientes values('Stower', 'Nona', 15, 'Femenino', '699 Michigan Junction', 'CoberturaBasica');
insert into pacientes values('Spittle', 'Cece', 22, 'Masculino', '2892 Bluejay Junction', 'CoberturaBasica');
insert into pacientes values('Grassi', 'Deeann', 23, 'Femenino', '013 Clyde Gallagher Avenue', 'CoberturaBasica');
insert into pacientes values('Hawyes', 'Monte', 46, 'Masculino', '8649 Butterfield Trail', 'CoberturaBasica');
insert into pacientes values('Bockett', 'Brunhilda', 46, 'Femenino', '7482 Schurz Parkway', 'CoberturaBasica');
insert into pacientes values('Kinson', 'Donelle', 32, 'Femenino', '3192 Jenna Alley', 'CoberturaBasica');
insert into pacientes values('Crock', 'Pamella', 48, 'Femenino', '364 Michigan Park', 'CoberturaBasica');
insert into pacientes values('Gerb', 'Abbie', 54, 'Femenino', '58 Ramsey Parkway', 'CoberturaBasica');
insert into pacientes values('Mockes', 'Christan', 45, 'Femenino', '0 Westridge Drive', 'CoberturaBasica');
insert into pacientes values('Faveryear', 'Alberik', 23, 'Masculino', '467 Duke Alley', 'CoberturaBasica');
insert into pacientes values('DAlessio', 'Brennan', 55, 'Masculino', '354 Roth Alley', 'CoberturaBasica');
insert into pacientes values('Dongles', 'Silva', 60, 'Femenino', '42724 Heath Parkway', 'CoberturaBasica');
insert into pacientes values('Woodcroft', 'Layney', 53, 'Femenino', '158 Eastlawn Place', 'CoberturaBasica');
insert into pacientes values('Bonass', 'Caroljean', 30, 'Femenino', '52507 Kedzie Park', 'CoberturaBasica');
insert into pacientes values('Doreward', 'Mel', 32, 'Masculino', '3737 Kensington Parkway', 'CoberturaBasica');
insert into pacientes values( 'DSouza', 'Mareah', 29, 'Femenino', '2 Sundown Street', 'CoberturaCompleta');
insert into pacientes values( 'Giffon', 'Ava', 41, 'Femenino', '15 Longview Avenue', 'CoberturaCompleta');
insert into pacientes values( 'Jerams', 'Arleyne', 36, 'Femenino', '87 Helena Trail', 'CoberturaCompleta');
insert into pacientes values( 'Noquet', 'Kizzie', 21, 'Femenino', '24999 Browning Way', 'CoberturaCompleta');
insert into pacientes values( 'Antonucci', 'Findley', 31, 'Masculino', '62413 Jackson Crossing', 'CoberturaCompleta');
insert into pacientes values( 'Garnall', 'Armstrong', 28, 'Masculino', '811 Arkansas Drive', 'CoberturaCompleta');
insert into pacientes values( 'Alltimes', 'Hobie', 28, 'Masculino', '18953 Golf Course Junction', 'CoberturaCompleta');
insert into pacientes values( 'Borges', 'Mag', 25, 'Femenino', '906 Corben Road', 'CoberturaCompleta');
insert into pacientes values( 'OCannavan', 'Meris', 31, 'Femenino', '44 Kim Park', 'CoberturaCompleta');
insert into pacientes values( 'Algeo', 'Marcy', 42, 'Femenino', '72 Arizona Drive', 'CoberturaCompleta');
insert into pacientes values( 'Ashford', 'Torey', 53, 'Femenino', '6 Hayes Road', 'CoberturaCompleta');
insert into pacientes values( 'Nodes', 'Lezlie', 29, 'Femenino', '3 Riverside Hill', 'CoberturaCompleta');
insert into pacientes values( 'Whittaker', 'Stephanus', 37, 'Masculino', '8 Valley Edge Park', 'CoberturaCompleta');
insert into pacientes values( 'Goldsbrough', 'Kippie', 23, 'Femenino', '12 Mcguire Plaza', 'CoberturaCompleta');
insert into pacientes values( 'Rothert', 'Ricard', 60, 'Masculino', '8347 Old Shore Street', 'CoberturaCompleta');
insert into pacientes values( 'Martinho', 'Clemente', 58, 'Masculino', '2098 Di Loreto Center', 'CoberturaCompleta');
insert into pacientes values( 'Tripon', 'Shalne', 30, 'Femenino', '6572 Monica Place', 'CoberturaCompleta');
insert into pacientes values( 'Bottrill', 'Giovanni', 39, 'Masculino', '1357 Fairfield Point', 'CoberturaCompleta');
insert into pacientes values( 'Loughhead', 'Alano', 47, 'Masculino', '99138 Orin Alley', 'CoberturaCompleta');
insert into pacientes values( 'Paulo', 'Kiersten', 22, 'Femenino', '22834 Maywood Way', 'CoberturaCompleta');
insert into pacientes values( 'Vyvyan', 'Hobard', 36, 'Masculino', '6397 Brickson Park Plaza', 'CoberturaCompleta');
insert into pacientes values( 'Anderbrugge', 'Charisse', 28, 'Femenino', '8268 Express Place', 'CoberturaCompleta');
insert into pacientes values( 'Crosscombe', 'Morganica', 46, 'Femenino', '8 Superior Park', 'CoberturaCompleta');
insert into pacientes values( 'Dimitresco', 'Harlen', 29, 'Masculino', '59 Division Lane', 'CoberturaCompleta');
insert into pacientes values( 'Maharey', 'Dee dee', 54, 'Femenino', '195 Main Point', 'CoberturaCompleta');
insert into pacientes values( 'Judge', 'Clive', 29, 'Masculino', '448 Sullivan Lane', 'CoberturaCompleta');
insert into pacientes values( 'Skippen', 'Farr', 15, 'Masculino', '62392 Monterey Circle', 'CoberturaCompleta');
insert into pacientes values( 'McAlindon', 'Elsey', 46, 'Femenino', '9041 Londonderry Alley', 'CoberturaCompleta');
insert into pacientes values( 'Serman', 'Marven', 37, 'Masculino', '5858 Grayhawk Street', 'CoberturaCompleta');
insert into pacientes values( 'Bruneau', 'Alwyn', 24, 'Masculino', '7339 Carpenter Parkway', 'CoberturaCompleta');
insert into pacientes values( 'Guisler', 'Quentin', 32, 'Masculino', '9 Commercial Point', 'CoberturaCompleta');
insert into pacientes values( 'Reynoldson', 'Lovell', 31, 'Masculino', '1 Farwell Crossing', 'CoberturaCompleta');
insert into pacientes values( 'Bauduin', 'Tracy', 54, 'Masculino', '22 Pierstorff Plaza', 'CoberturaCompleta');
insert into pacientes values( 'Ceaser', 'Charla', 51, 'Femenino', '17521 Forest Terrace', 'CoberturaCompleta');
insert into pacientes values( 'Kumar', 'Martie', 18, 'Femenino', '4 Schmedeman Drive', 'CoberturaCompleta');
insert into pacientes values( 'Street', 'Ariel', 30, 'Femenino', '19370 Schmedeman Place', 'CoberturaCompleta');
insert into pacientes values( 'Coalbran', 'Frederick', 32, 'Masculino', '664 Fisk Drive', 'CoberturaCompleta');
insert into pacientes values( 'Rielly', 'Agnesse', 22, 'Femenino', '128 Oxford Road', 'CoberturaCompleta');
insert into pacientes values( 'Zanolli', 'Byran', 43, 'Masculino', '94072 Warner Drive', 'CoberturaCompleta');
insert into pacientes values( 'Tuffley', 'Nils', 52, 'Masculino', '7002 Comanche Alley', 'CoberturaCompleta');
insert into pacientes values( 'Frankiewicz', 'Zulema', 41, 'Femenino', '6030 Eliot Parkway', 'CoberturaCompleta');
insert into pacientes values( 'Crowd', 'Melvyn', 25, 'Masculino', '495 Victoria Drive', 'CoberturaCompleta');
insert into pacientes values( 'Arrighi', 'Emmie', 59, 'Femenino', '6 Maple Drive', 'CoberturaCompleta');
insert into pacientes values( 'Janks', 'Flora', 46, 'Femenino', '83 Oriole Crossing', 'CoberturaCompleta');
insert into pacientes values( 'Matejic', 'William', 59, 'Masculino', '221 Northwestern Court', 'CoberturaCompleta');
insert into pacientes values( 'Bellefant', 'Leigh', 19, 'Masculino', '13873 Eastlawn Avenue', 'CoberturaCompleta');
insert into pacientes values( 'Rourke', 'Esma', 45, 'Femenino', '606 Elgar Street', 'CoberturaCompleta');
insert into pacientes values( 'Coburn', 'Siffre', 34, 'Masculino', '919 Pearson Center', 'CoberturaCompleta');
insert into pacientes values( 'Heel', 'Neale', 20, 'Masculino', '9526 Novick Trail', 'CoberturaCompleta');
insert into pacientes values( 'Sleight', 'Catha', 45, 'Femenino', '2174 Marquette Parkway', 'NoTiene');
insert into pacientes values( 'Draper', 'Zach', 52, 'Masculino', '152 Valley Edge Avenue', 'NoTiene');
insert into pacientes values( 'Richings', 'Had', 37, 'Masculino', '8050 Farwell Court', 'NoTiene');
insert into pacientes values( 'Tessier', 'Farrell', 47, 'Masculino', '608 Cambridge Alley', 'NoTiene');
insert into pacientes values( 'Crepel', 'Cosette', 58, 'Femenino', '16 Green Ridge Lane', 'NoTiene');
insert into pacientes values( 'Crumbleholme', 'Leone', 54, 'Femenino', '30989 Golf Hill', 'NoTiene');
insert into pacientes values( 'Chartres', 'Manny', 22, 'Masculino', '99 Nancy Plaza', 'NoTiene');
insert into pacientes values( 'Edmund', 'Hildegarde', 36, 'Femenino', '1 Fremont Trail', 'NoTiene');
insert into pacientes values( 'Stayt', 'Claiborn', 40, 'Masculino', '66 Milwaukee Trail', 'NoTiene');
insert into pacientes values( 'MacDougal', 'Ive', 46, 'Masculino', '0979 Sundown Road', 'NoTiene');
insert into pacientes values( 'Gullen', 'Fabio', 18, 'Masculino', '6721 Hayes Junction', 'NoTiene');
insert into pacientes values( 'Alexsandrowicz', 'Antoni', 35, 'Masculino', '317 Ilene Terrace', 'NoTiene');
insert into pacientes values( 'Eadmeades', 'Emilee', 39, 'Femenino', '872 La Follette Trail', 'NoTiene');
insert into pacientes values( 'Byrne', 'Eldin', 60, 'Masculino', '91 Trailsway Park', 'NoTiene');
insert into pacientes values( 'Espie', 'Merill', 35, 'Masculino', '08 Schlimgen Point', 'NoTiene');
insert into pacientes values( 'Winear', 'Sheree', 16, 'Femenino', '1434 Green Trail', 'NoTiene');
insert into pacientes values( 'Bathurst', 'Patsy', 26, 'Femenino', '2247 Roth Court', 'NoTiene');
insert into pacientes values( 'Daouse', 'Lesly', 53, 'Femenino', '29 Westridge Court', 'NoTiene');
insert into pacientes values( 'Broster', 'Alvina', 59, 'Femenino', '25 Armistice Crossing', 'NoTiene');
