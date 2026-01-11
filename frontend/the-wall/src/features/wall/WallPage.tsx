import PublishForm from "./components/PublishForm";
import Loading from "./components/Loading";
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

    if(loading) {
        return <Loading />;
    }

    return (
        <>
            <PublishForm onPublish={handlePublish} />
            {phrases.map((phraseText, index) => (
                <p key={index}>{phraseText}</p>
            ))}
        </>
    );
}

export default WallPage;