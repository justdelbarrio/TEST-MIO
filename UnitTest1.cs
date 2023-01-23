using CassaforteMain;

namespace TestMiaClasse
{
    public class UnitTest1
    {
        [Fact]
        public void TestApri1()
        {
            Cassaforte c1 = new Cassaforte(5323, "Phoenixss", "1185K", "752Gj4j50oM1", false);

            //Controlliamo se funziona con la stringa, in alternativa si potrebbe fare controllando la var Stato

            Assert.True(c1.Apri(c1.CodiceUtente) == "Cassaforte aperta con successo.");
        }

        [Fact]
        public void TestApri2()
        {
            Cassaforte c1 = new Cassaforte(5323, "Phoenixss", "1185K", "752Gj4j50oM1", false);

            //False perchè dando come parametro il produttore ovviamente non sarà il codice corretto

            Assert.False(c1.Apri(c1.Produttore) == "Cassaforte aperta con successo.");
        }

        [Fact]
        public void TestApri3()
        {
            Cassaforte c1 = new Cassaforte(5323, "Phoenixss", "1185K", "752Gj4j50oM1", false);

            c1.Apri("asdasd");
            c1.Apri("asdasd");
            c1.Apri("asdasd");
            c1.Apri("asdasd");
            c1.Apri("asdasd");

            //Il test uscirà con esito negativo e descritto con una eccezione, perciò è corretto (questo test prova il blocco della cassaforte dopo i 5 tentativi errati)

            Assert.True(c1.Bloccata);
        }

        [Fact]
        public void TestApri4()
        {
            Cassaforte c1 = new Cassaforte(5323, "Phoenixss", "1185K", "752Gj4j50oM1", false);

            c1.Apri("5323");


            //Testiamo il caso del quinto tentativo errato di apertura

            Assert.True(c1.ApertureEffettuate==1);
        }

        [Fact]
        public void TestChiudi1()
        {
            Cassaforte c1 = new Cassaforte(5323, "Phoenixss", "1185K", "752Gj4j50oM1", false);

            //Testiamo il caso in cui la cassaforte sia chiusa e si voglia chiudere ancora

            Assert.True(c1.Chiudi() == "Cassaforte già chiusa.");
        }

        [Fact]
        public void TestChiudi2()
        {
            Cassaforte c1 = new Cassaforte(5323, "Phoenixss", "1185K", "752Gj4j50oM1", false);

            c1.Apri(c1.CodiceUtente);
            //Testiamo il caso in cui la cassaforte sia aperta e si voglia chiudere

            Assert.True(c1.Chiudi() == "Cassaforte chiusa con successo.");
        }

        [Fact]
        public void Test7()
        {
            Cassaforte c1 = new Cassaforte(5323, "Phoenixss", "1185K", "752Gj4j50oM1", false);        
            //Testiamo il caso in cui la cassaforte sia bloccata e si voglia sbloccare col codice da 12 cifre alfanumerico

            Assert.True(c1.Sblocca(c1.CodiceSblocco) == "Cassaforte aperta con successo.");
        }

        [Fact]
        public void Test8()
        {
            Cassaforte c1 = new Cassaforte(5323, "Phoenixss", "1185K", "752Gj4j50oM1", false);
            
            //Controlliamo il caso in cui si sbagli il codice di sblocco (devo correggere nella classe e mettere l'eccezione

            Assert.True(c1.Sblocca(c1.Produttore) == "Codice di sblocco errato.");
        }

       /* [Fact]
        public void Test9()
        {
            Cassaforte c1 = new Cassaforte(5323, "Phoenixss", "1185K", "752Gj4j50oM1", false);

            //Controlliamo il caso in cui si sbagli il codice di sblocco (devo correggere nella classe e mettere l'eccezione
            string a = c1.CodiceUtente;
            c1.ImpostaCodiceUtente(c1.CodiceUtente);

            Assert.True(c1.CodiceUtente != a);
        }*/



    }
}