/* Conventions
 * Booleen -> INTEGER, 0 = false, 1 = true
 * Date -> Stockage timestamp yyyyMMddHHmmssfff (TEXT) et convertion avec les méthodes C# en DateTime C#
 * Enumeration -> Champ TEXT Gérées en C#
*/

PRAGMA foreign_keys = ON;

/* Equipment représente un 'type' d'Item comme "Bouteille d'oxygen */
CREATE TABLE Equipment (
    id              INTEGER     PRIMARY KEY AUTOINCREMENT NOT NULL,
    name            TEXT        UNIQUE NOT NULL,
    maxUses         INTEGER     NULL
);

/* "La bouteille d'oxygen n°27 qu'on a acheté le 17 février" */
CREATE TABLE Item (
	id	            INTEGER     PRIMARY KEY AUTOINCREMENT NOT NULL,
	serialNumber    TEXT        NULL,
	expiryDate      TEXT		NULL,
	buyingDate      TEXT		NOT NULL,
	barCode         INTEGER     UNIQUE NOT NULL,
	state           INTEGER     NOT NULL DEFAULT(0), /* Enumeration : bought(0), lost, trashed */
	idEquipment		INTEGER     REFERENCES Equipment(id) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL
);

/* Une date debut a NULL signifie que l'intervetion est en attente */
CREATE TABLE Intervention (
    id              INTEGER     PRIMARY KEY AUTOINCREMENT NOT NULL,
	name			TEXT		NOT NULL,
    startedDate     TEXT	    NULL,
    endedDate       TEXT	    NULL,
	checkingState   INTEGER     NOT NULL DEFAULT(0) /* Enumeration waiting(0), usedObjectChecked, usedAndNotUsedObjectChecked, done */
);

/* Association n-aire entre Item et Intervention */
CREATE TABLE ItemIntervention (
	used			INTEGER		NULL,
	idItem          INTEGER     REFERENCES Item(id) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL,
	idIntervention  INTEGER     REFERENCES Intervention(id) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL,
	PRIMARY KEY(idItem,idIntervention)
);

/* Pas d'accesseur sur locked, un compte super-admin est crée en dur locké + un guest */
CREATE TABLE Account (
    id              INTEGER     PRIMARY KEY AUTOINCREMENT NOT NULL,
	login           TEXT        NOT NULL,
    password	    TEXT        NOT NULL,
    locked          INTEGER     NOT NULL DEFAULT(0),
	/* Les différents types de droits */
	/*can_edit_intervention   INTEGER     NOT NULL DEFAULT(1),*/
	can_edit_stock          INTEGER     NOT NULL DEFAULT(0),
	can_edit_account        INTEGER     NOT NULL DEFAULT(0)
);

/*CREATE TABLE AccountAdmin (
    id              INTEGER     PRIMARY KEY REFERENCES Account(id) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL,
    login           TEXT        NOT NULL,
    password	    TEXT        NOT NULL
);

CREATE TABLE AccountUser (
    id              INTEGER     PRIMARY KEY REFERENCES Account(id) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL,
    login           TEXT        NOT NULL,
    password        TEXT        NOT NULL
);

CREATE TABLE AccountGuest (
    id              INTEGER     PRIMARY KEY REFERENCES Account(id) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL
);*/

/* Compte admin */
INSERT INTO Account VALUES (1,"admin","admin",1,1,1);
/*INSERT INTO AccountAdmin VALUES (1,"admin","admin");*/

/* Compte invité */
/*INSERT INTO Account VALUES (2,1);*/
/*INSERT INTO AccountGuest VALUES (2);*/