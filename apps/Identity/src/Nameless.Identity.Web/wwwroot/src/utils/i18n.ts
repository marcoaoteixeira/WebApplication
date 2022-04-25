import i18n from "i18next";
import { initReactI18next } from "react-i18next";
import LanguageDetector from "i18next-browser-languagedetector";

import ptBRTranslation from "../locales/pt-BR/translation.json";
import enUSTranslation from "../locales/en-US/translation.json";

const resources = {
  pt_br: {
    translation: ptBRTranslation
  },
  en_us: {
    translation: enUSTranslation
  }
};

i18n
  .use(LanguageDetector)
  .use(initReactI18next)
  .init({
    resources: resources,
    lng: "pt_br",
    fallbackLng: "en_us",
    preload: ["pt_br", "en_us"],
    ns: "translation",
    interpolation: {
      escapeValue: false
    }
  }, (err) => {
    if (err) { return console.log(err); }

    console.log("i18next ready...");
  });

export default i18n;