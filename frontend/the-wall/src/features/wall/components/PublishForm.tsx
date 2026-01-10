import { useState } from 'react';

function PublishForm({ onPublish }: { onPublish: (phraseText: string) => void }) {

    const [phraseText, setPhraseText] = useState("");
    const [font, setFont] = useState("");
    const [fontSize, setFontSize] = useState(0);
    const [color, setColor] = useState("#000000");

    const handleSubmit = (e: React.FormEvent) => {
        e.preventDefault();
        onPublish(phraseText);
        setPhraseText("");
    }


    return (
        <div>
            <h2>Publish a phrase</h2>
            <form onSubmit={handleSubmit}>

                <label htmlFor="phrase-text">
                    Text
                    <br />
                    <textarea
                        id="phrase-text"
                        value={phraseText}
                        onChange={(e) => setPhraseText(e.target.value)}
                        required></textarea>
                </label>
                <br />

                <label htmlFor="font-select">
                    Font
                    <br />
                    <select id="font-select" value={font} onChange={(e) => setFont(e.target.value)}>
                        <option value="Arial">Arial</option>
                        <option value="Times New Roman">Times New Roman</option>
                        <option value="Courier New">Courier New</option>
                    </select>
                </label>
                <br />

                <label htmlFor="font-size-select">
                    Size
                    <br />
                    <select id="font-size-select" value={fontSize} onChange={(e) => setFontSize(Number(e.target.value))}>
                        <option value="10">10</option>
                        <option value="11">11</option>
                        <option value="12">12</option>
                        <option value="13">13</option>
                        <option value="14">14</option>
                        <option value="15">15</option>
                    </select>
                </label>
                <br />

                <label htmlFor="color-input">
                    Color
                    <br />
                    <input id="color-input" type="color" value={color} onChange={(e) => setColor(e.target.value)}/>
                </label>
                <br />

                <button type="submit">Publish</button>
            </form>
        </div>
    );
}

export default PublishForm;