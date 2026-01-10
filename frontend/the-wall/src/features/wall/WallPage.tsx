import PublishForm from "./components/PublishForm";
import { useState } from "react";

function WallPage() {

    const [phrases, setPhrases] = useState<string[]>([]);

    const handlePublish = (text: string) => {
        setPhrases((prev) => [...prev, text]);
    };


    return (
        <div>
            <PublishForm onPublish={handlePublish}/>

            {phrases.map((phraseText, index)=>(
                <p key={index}>{phraseText}</p>
            ))}
        </div>);
}

export default WallPage;