using BridgeDesignPattern;

new Gonder(new EPostaIleGonder()).MesajGonder("ahmet@gmail.com", "Test Postam");
new Gonder(new WhatsAppIleGonder()).MesajGonder("Annem", "Test Whatsapp Mesajım");
new Gonder(new SlackIleGonder()).MesajGonder("Patron", "Test Slack Mesajım");

