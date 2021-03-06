﻿using System.Collections.Generic;

namespace dotNetConfPL.Web.Model
{
    // images dir: http://dotnetconfpl.apphb.com/Content/images/
    public class DbContext
    {
        List<Session> _sessions = new List<Session>();
        List<Speaker> _speakers = new List<Speaker>();

        public DbContext()
        {
            //var maciej_aniserowicz = new Speaker
            //{
            //    Id = 1,
            //    Name = "Maciej Aniserowicz",
            //    About = "MVP i najpopularniejszy <a href=\"http://www.maciejaniserowicz.com/\">blogger</a> w polskim środowisku .NET. Miłośnik testów jednostkowych, Gita i Resharpera, zatwardziały wróg TFSa i Sharepointa. Z zawodu programista/architekt .NET w firmie Ultrico. Wcześniej pracował w firmie Predica. Przez pewien czas był także Freelancerem. Ponadto jest dwukrotnym finalistą ImagineCup i byłym redaktorem <a href=\"http://codeguru.geekclub.pl/\">CodeGuru.pl</a>.",
            //    Photo = "maciej_aniserowicz.jpg"
            //};

            //var barbara_fusinska = new Speaker
            //{
            //    Id = 2,
            //    Name = "Barbara Fusińska",
            //    About = "Basia pracowała w małej, średniej oraz dużej firmie, pełniąc role zarówno programistki, architekta, jak i kierownika. Od samego początku związana jest z platformą .NET, tworząc najpierw aplikacje desktopowe, a następnie webowe. Obecnie szuka inspiracji by rozpoczac nowa przygodę, jeździ na koferencje i <a href=\"http://barbarafusinska.com/\">blogguje</a>. Jest zwolennikiem współodpowiedzialności za wyniki pracy zespołu oraz teorii mówiącej, że to co tworzy grupa jest większe niż suma wyników poszczególnych osób. Żywiołowo reaguje na hasło rozwój we wszystkich odmianach - szkolenia, konferencje, zwykłe i niezwykłe rozmowy. Wciąż szuka okazji, by odkrywać potencjał drzemiący w każdym człowieku.",
            //    Photo = "barbara_fusinska.jpg"

            //};

            //var patryk_goralowski = new Speaker
            //{
            //    Id = 3,
            //    Name = "Patryk Góralowski",
            //    About = "18 lat w sprzedaży; 10 lat w marketingu, od 8 lat prowadzi warsztaty, szkolenia, moderowane sesje strategiczne i coachingowe grupowe oraz indywidualne. Prelegent, moderator i wykładowca. Właściciel firmy <a href=\"http://tristantresar.com\">tristantresar.com</a>. Certyfikowany trener i konsultant SenseMaking® w firmie Freemen. Dyrektor ds. zarządzania konsumenckimi kategoriami produktów Microsoft. Certyfikowany trener i doradca w szkole sprzedaży Jeffrey' a Gitomer'a. Doradca ds. kariery w Chartered Institute of Marketing.",
            //    Photo = "patryk_goralowski.jpg"
            //};

            //var maciej_grabek = new Speaker
            //{
            //    Id = 4,
            //    Name = "Maciej Grabek",
            //    About = "MVP, <a href=\"http://maciejgrabek.com/\">blogger</a>, głównie zajmuje się platformą Windows Phone. Prelegent na <a href=\"http://www.mtskonferencja.pl/\">Microsoft Technology Summit</a> w 2011, 2012 i 2013 roku, były redaktor <a href=\"http://codeguru.geekclub.pl/\">CodeGuru.pl</a>, współtwórca serii webcastów poświęconych technologii <a href=\"http://channel9.msdn.com/Series/Kurs-programowania-Windows-Phone-7\">Windows Phone 7</a> oraz <a href=\"http://channel9.msdn.com/Series/Tworzenie-aplikacji-dla-systemu-Windows-Phone-8\">Windows Phone 8</a>. Ponadto współzałożyciel <a href=\"http://wss.pl/group-134/Default.aspx\">Toruńskiej Grupy Developerów .NET</a>. Zajmuje się .NETem od czasów studiów i wersji 1.1. Obecnie pracuje dla <a href=\"http://www.nordeamarkets.com\">Nordea Capital Markets IT</a>.",
            //    Photo = "maciej_grabek.png"
            //};

            //var jakub_gutkowski = new Speaker
            //{
            //    Id = 5,
            //    Name = "Jakub Gutkowski",
            //    About = "MVP oraz <a href=\"http://blog.gutek.pl/\">blogger</a>. Absolwent Polsko-Japońskiej Wyższej Szkoły Technik Komputerowych w Warszawie, nie potrafiący zagrzać sobie miejsca. Obecnie pracuje zdalnie bo tak mu łatwiej, raz w kawiarniach, raz w domu. Daje mu to okazję bawić się zawodowo różnymi technologiami i wieloma językami, choć próbuje być cool i rubinem też się bawi.",
            //    Photo = "jakub_gutkowski.png"
            //};

            //var michal_lusiak = new Speaker
            //{
            //    Id = 7,
            //    Name = "Michał Łusiak",
            //    About = "Michał pochodzi z Trójmiasta, ale aktualnie mieszka w Szwecji i pracuje dla <a href=\"http://tretton37.com/\">tretton37</a>. W ciągu dnia programuje backend dla aplikacji webowych. W nocy wielki fan programowania funkcyjnego. Miał okazje pracować w firmach bardzo dużych i bardzo małych na bardzo wielu platformach programistycznych, ale w tej chwili skupia się głownie na .NET-cie. W wolnych chwilach uwielbia eksperymentować z nowymi technologiami i hardwarem. Kiedy nie programuje, zaspakaja swoje uzależnienie od adrenaliny - lata na paralotni, jeździ na jednej narcie lub wypada z samolotu.",
            //    Photo = "michal_lusiak.jpg"
            //};

            //var filip_woj = new Speaker
            //{
            //    Id = 8,
            //    Name = "Filip Wojcieszyn",
            //    About = "MVP, <a href=\"http://www.strathweb.com/\">blogger</a>, autor, aktywny członek społeczności Open Source (m.in. koordynator <a href=\"http://scriptcs.net/\">scriptcs</a> i <a href=\"https://github.com/WebApiContrib\">WebAPIContrib</a>). Członek ASP.NET Web API Advisory Board. Doświadczony w tworzeniu dużych aplikacji webowych w Polsce, Wielkiej Brytanii, Finlandii, Kanadzie. Obecnie mieszka w Szwajcarii i pracuje w Arcmedia AG. Dostępny na Twitterze jako <a href=\"http://twitter.com/filip_woj\">@filip_woj</a>.",
            //    Photo = "filip_woj.jpg"
            //};
            

            //var session1 = new Session
            //{
            //    Id = 1,
            //    Time = "15:00 - 16:00",
            //    Title = "Testy jednostkowe w praktyce, vol 2",
            //    Speaker = maciej_aniserowicz,
            //    About = "W poprzedniej edycji <a href=\"http://dotnetconf.pl/2013\">dotNetConfPL</a> przyjrzeliśmy się narzędziom wykorzystywanym podczas pisania testów na platformie .NET oraz jednemu z wielu scenariuszy, w których testy okazują się niezmiernie pomocne w pracy programisty - eksplorowaniu zewnętrznych systemów i dokumentowaniu komunikacji z nimi. Podczas tegorocznego wystąpienia będziemy kontynuować temat przyglądając się innym zastosowaniom testów. Zobaczymy jak testy jednostkowe sprawdzają się w charakterze \"project-specific-compilator (tm)\". Brzmi enigmatycznie? I dobrze :). Spojrzymy też na testy bazy danych. Kiedy warto je pisać i jak robić to w miarę bezboleśnie? Podywagujemy również nad tematem czytelności testów. Testy powinny służyć za dokumentację tworzonego systemu, więc ich treść musi być czytelna i zrozumiała już na pierwszy rzut oka. Jak można to osiągnąć? Warto obejrzeć <a href=\"http://www.youtube.com/watch?v=gQaShMN_tN8\">prezentację Maćka z ubiegłorocznej edycji</a>.",
            //    YoutubeUrl = "http://www.youtube.com/embed/zfyUQKktc4w"
            //};

            //var session2 = new Session
            //{
            //    Id = 2,
            //    Time = "20:00 - 21:00",
            //    Title = "Wymagania biznesowe w formie kodu, czyli kilka słów na temat BDD z użyciem SpecFlow",
            //    Speaker = maciej_grabek,
            //    About = "Testy są niezmiernie ważną częścią procesu wytwarzania oprogramowania. Okazuje się, że w formie testów jednostkowych możemy przechowywać wymagania biznesowe, które będą zrozumiałe nie tylko dla programistów, ale również dla klientów. Co więcej - klient sam (lub z niewielką pomocą) może stworzyć szereg wymagań opisujących zachowanie (behaviour) elementów systemu, które następnie mogą zostać zamienione na  odpowiedni zbiór testów. Tego typu podejście można określić jako BDD (Behaviour Driven Development). Podczas prezentacji wspólnie przyjrzymy się temu jaka siła drzemie w tym narzędziu i jakie ma ono wady.",
            //    YoutubeUrl = "http://www.youtube.com/embed/-OLJ0epfZ7U"
            //};

            //var session4 = new Session
            //{
            //    Id = 4,
            //    Time = "16:00 - 17:00",
            //    Title = "Wszystko co chciałbyś wiedzieć o Roslyn",
            //    Speaker = filip_woj,
            //    About = "Swoistą tradycją kompilowanych języków jest to, że kompilator napisany jest w języku który kompiluje (klasyczny \"dogfooding\"). Przez blisko 15 lat, sztandarowa implementacja C#, Microsoft Visual C#, była kompilowana przy użyciu kompilatora napisanego w C++. Poprzez Roslyn, kompilatora open source następnej generacji, który napędza Visual Studio 14, doczekaliśmy się wreszcie od Microsoftu kompilatora C#, napisanego właśnie w C#. Podczas tej sesji przedyskutujemy co tak naprawdę Roslyn daje programistom: zajrzymy w Roslyn Language Services, Roslyn Compiler-as-a-Service oraz możliwości analizy kodu przy pomocy Roslyn. Na koniec zastanowimy się na gigantycznymi zmianami dla .NET, jakie niesie za sobą Roslyn.",
            //    YoutubeUrl = "http://www.youtube.com/embed/akFWDp1v-Oo"
            //};

            //var session5 = new Session
            //{
            //    Id = 5,
            //    Time = "18:00 - 19:00",
            //    Title = "Server Side czy/i Client Side MVC???",
            //    Speaker = jakub_gutkowski,
            //    About = "Coraz częściej stoimy przed wyborem przy nowym projekcie - pójść w pełni w MVC po stronie serwera? Czy może wykorzystać jQuery? Czy możne jeden z super frameworków (<a href=\"http://todomvc.com\">www.todomvc.com</a>, który \"załatwi\" wszystko? A może...da się to rozsądnie pożenić? O rozwiązaniu tych jak i innych problemów na podstawie AngularJS (ale i nie tylko) i ASP.NET MVC (to tylko framework) dowiesz się na prezentacji.",
            //    YoutubeUrl = "http://www.youtube.com/embed/SB994BIfW3k"
            //};

            //var session6 = new Session
            //{
            //    Id = 6,
            //    Time = "17:00 - 18:00",
            //    Title = "Programowanie zorientowane aspektowo (AOP)",
            //    Speaker = barbara_fusinska,
            //    About = "Programowanie zorientowane aspektowo (AOP) przydaje się wszędzie tam, gdzie pojawiają się tzw. cross cutting concerns. Aspekty mogą pomóc programistom w pisaniu piękniejszego kodu, nie po to jedynie, by dobrze się go czytało, ale przede wszystkim by tworzyć logikę biznesową w sposób spójny z tym jak ją projektujemy. Skupię się nie tyle na samej idei, co na przedstawieniu mniej sztandarowych zastosowań niż logowanie wywołań metod czy bezpieczeństwo. Pokażę przypadki użycia aspektów w rzeczywistych sytuacjach, gdy ich wykorzystanie uporządkowało projekt, implementację oraz ułatwiło testowanie kodu.",
            //    YoutubeUrl = "http://www.youtube.com/embed/es_qdXKSh7M"

            //};

            //var session7 = new Session
            //{
            //    Id = 7,
            //    Time = "19:00 - 20:00",
            //    Title = "Talent za 2 dolary. Skusisz się!",
            //    Speaker = patryk_goralowski,
            //    About = "Czasami zdarza się, że ktoś pyta Cię kim jesteś? Pyta w różnych sytuacjach życiowych, mniej i bardziej ważnych. Niełatwo na to pytanie  jest odpowiedzieć, zwłaszcza kiedy ma się 3 minuty. Niełatwo - jednak są sposoby by było łatwiej i pewniej było. O jednym z takich sposobów będzie dziś. O jednej z takich inwestycji w siebie opowiem Wam w prostych, nieskomplikowanych słowach. Wystarczy mieć 2$ i 20 minut czasu by zdobyć o sobie wiedzę o tym w czym jesteś utalentowany lub utalentowana. Potem już trzeba wiedzą tą zarządzać i rozwijać swoje talenty. Zainwestuj! Warto! Dopóki robisz to co zawsze - będziesz miał to co zwykle! Przygotuj kartkę papieru i ołówek. Będzie to sesja interaktywna.",
            //    YoutubeUrl = "http://www.youtube.com/embed/hbxTiQjtyt0"
            //};

            //var session8 = new Session
            //{
            //    Id = 8,
            //    Time = "21:00 - 22:00",
            //    Title = "WTF# - czym jest F# i dlaczego powinno Cię to obchodzić",
            //    Speaker = michal_lusiak,
            //    About = "Prawdopodobnie coraz więcej słyszysz o programowaniu funkcyjnym. W modzie jest programować w Clojure, Scali albo Haskellu. .NET nie pozostał w tyle i ma swój język funkcyjny - F#. W tej prezentacji Michał opowie trochę o tym czym właściwie jest F#, do czego może Ci się przydać i jak zacząć z nim przygodę. Pokaże też kilka możliwości tego języka, które uważa za najbardziej interesujace. Nie będzie natomiast zbyt dużo mówił o programowaniu funkcyjnym.",
            //    YoutubeUrl = "http://www.youtube.com/embed/a-ce4aGZ18I"
            //};

            //_speakers.Add(maciej_aniserowicz);
            //_speakers.Add(barbara_fusinska);
            //_speakers.Add(patryk_goralowski);
            //_speakers.Add(maciej_grabek);
            //_speakers.Add(jakub_gutkowski);
            //_speakers.Add(michal_lusiak);
            //_speakers.Add(filip_woj);            

            //_sessions.Add(session1);
            //_sessions.Add(session2);
            //_sessions.Add(session4);
            //_sessions.Add(session5);
            //_sessions.Add(session6);
            //_sessions.Add(session7);
            //_sessions.Add(session8);
        }

        public List<Session> Sessions { get { return _sessions; } private set { _sessions = value; } }
        public List<Speaker> Speakers { get { return _speakers; } private set { _speakers = value;  } }
    }
}