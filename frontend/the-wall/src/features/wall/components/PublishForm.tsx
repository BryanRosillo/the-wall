import {useState} from 'react';

function PublishForm({onPublish}:{onPublish : (phraseText: string) => void}) {

    const [phraseText, setPhraseText] = useState("");

    const handleSubmit = (e: React.FormEvent) =>{
        e.preventDefault();
        onPublish(phraseText);
        setPhraseText("");
    }


    return (
        <div>
            <h2>Publish a phrase</h2>
            <form onSubmit={handleSubmit}>
                <textarea 
                aria-label="Phrase text" 
                value={phraseText}
                onChange={(e) => setPhraseText(e.target.value)}
                required></textarea><br />
                <button type="submit">Publish</button>
            </form>
        </div>
    );
}

export default PublishForm;