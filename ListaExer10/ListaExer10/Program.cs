VooRegular economico = new VooRegular("UMACIDADEAE", "SP", "03/02/2024");
VooGrande grupoGrande = new VooGrande("ALGUMLUGAR", "BH", "02/03/2024");
VooUpgrade primeiraClasse = new VooUpgrade("Paris", "SLA", "1/01/2024");

        
economico.reservar();
grupoGrande.reservar();
primeiraClasse.reservar();

        
economico.cancelar();
grupoGrande.cancelar();
primeiraClasse.cancelar();

       
economico.status();
grupoGrande.status();
primeiraClasse.status();
