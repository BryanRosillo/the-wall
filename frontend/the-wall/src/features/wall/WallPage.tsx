import PublishForm from "./components/PublishForm";
import { fetchPhrases } from './services/phraseService'
import { useState, useEffect } from "react";

function WallPage() {

    const [phrases, setPhrases] = useState<string[]>([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        fetchPhrases().then(data => {
            setPhrases(data);
            setLoading(false);
        })
    }, []);

    const handlePublish = (text: string) => {
        setPhrases((prev) => [...prev, text]);
    };


    return (
        <div>
            {loading ? (
                <div aria-label="loading">Loading...</div>
            ) : (
                <>
                    <PublishForm onPublish={handlePublish} />
                    {phrases.map((phraseText, index) => (
                        <p key={index}>{phraseText}</p>
                    ))}
                </>)}
        </div>);
}

export default WallPage;