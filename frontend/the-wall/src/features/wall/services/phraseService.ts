export const fetchPhrases = async () => {
    return fetch("/wall").then(phrase => phrase.json());
};