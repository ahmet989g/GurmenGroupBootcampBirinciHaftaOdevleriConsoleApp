using Dependency_Inversion_Principle.Abstract;

Sekil daire = new Sekil(new DaireCizdir());
daire.SekilCiz();

Sekil kare = new Sekil(new KareCizdir());
kare.SekilCiz();