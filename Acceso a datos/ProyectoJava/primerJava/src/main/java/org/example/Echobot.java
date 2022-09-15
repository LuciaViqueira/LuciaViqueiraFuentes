package org.example;

import org.telegram.telegrambots.bots.TelegramLongPollingBot;
import org.telegram.telegrambots.meta.TelegramBotsApi;
import org.telegram.telegrambots.meta.api.methods.send.SendMessage;
import org.telegram.telegrambots.meta.api.objects.Update;
import org.telegram.telegrambots.meta.exceptions.TelegramApiException;
import org.telegram.telegrambots.updatesreceivers.DefaultBotSession;

public class Echobot extends TelegramLongPollingBot {
    @Override
    public String getBotUsername() {
        return "AulanosaLucia_bot";
    }
    @Override
    public String getBotToken() {
        return "5652655935:AAE2PBAgclc7fj4xQhYruib8oZ2ZkDfDisA";
    }

    public SendMessage procesarMensaje(String chatId, String texto){
        SendMessage message = new SendMessage();
        message.setText("Me has dicho : " + texto);
        message.setChatId(String.valueOf(chatId));

        return message;
    }


    @Override
    public void onUpdateReceived(Update update) {
        final String messageTextRecibed  =update.getMessage().getText();

        final long chatId = update.getMessage().getChatId();

        SendMessage message = procesarMensaje(String.valueOf(chatId), messageTextRecibed);

        try{
            execute(message);
        }catch (TelegramApiException e){
            e.printStackTrace();
        }
    }
}
