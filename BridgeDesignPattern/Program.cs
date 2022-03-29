using BridgeDesignPattern.hasA;
using BridgeDesignPattern.isA;

// HAS-A
new Gonder(new EPostaIleGonder()).MesajGonder("ahmet@gmail.com", "Test Postam");
new Gonder(new WhatsAppIleGonder()).MesajGonder("Annem", "Test Whatsapp Mesajım");
new Gonder(new SlackIleGonder()).MesajGonder("Patron", "Test Slack Mesajım");


// IS-A
new GonderIsA().EPostaIleGonder("ahmet@gmail.com", "Test Postam");
new GonderIsA().WhatsAppIleGonder("Annem", "Test Postam");
new GonderIsA().SlackIleGonder("Patron", "Test Slack Mesajım");