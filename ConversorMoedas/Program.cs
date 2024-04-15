// See https://aka.ms/new-console-template for more information

using ConversorMoedas;

IMoedaMapper moedaMapper = new MoedaMapper();
var conversor = new ConversorMoedas.ConversorMoedas(moedaMapper);
conversor.ConverterMoeda();