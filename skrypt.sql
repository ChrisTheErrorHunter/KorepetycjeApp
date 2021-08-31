-- DROP TABLE lekcja;
-- DROP TABLE przedmiot;
-- DROP TABLE konto;
-- DROP TABLE uczen;
-- DROP TABLE klasa;
-- DROP TABLE korepetytor;


CREATE TABLE korepetytor (
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  login VARCHAR(30) NOT NULL,
  haslo VARCHAR(30) NOT NULL,
  czyAdministrator BIT NOT NULL
);

CREATE TABLE klasa (
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  nazwa VARCHAR(30) NOT NULL
);

CREATE TABLE uczen (
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  imie VARCHAR(30) NOT NULL,
  nazwisko VARCHAR(50),
  idKlasy INT NOT NULL,
  FOREIGN KEY (idKlasy) REFERENCES klasa(id)
);

CREATE TABLE konto (
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  idUcznia INT NOT NULL,
  czyBankowe BIT NOT NULL,
  FOREIGN KEY (idUcznia) REFERENCES uczen(id)
);


CREATE TABLE przedmiot (
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  nazwa VARCHAR(30) NOT NULL
);

CREATE TABLE lekcja (
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  temat VARCHAR(100),
  idPrzedmiotu INT NOT NULL,
  idUcznia INT NOT NULL,
  idKorepetytora INT NOT NULL,
  poczatek Datetime NOT NULL,
  czas int NOT NULL,
  czyZaplacona BIT,
  FOREIGN KEY (idUcznia) REFERENCES uczen(id),
  FOREIGN KEY (idKorepetytora) REFERENCES korepetytor(id),
  FOREIGN KEY (idPrzedmiotu) REFERENCES przedmiot(id)
);

INSERT INTO korepetytor (login, haslo, czyAdministrator ) VALUES ("admin","123",1);