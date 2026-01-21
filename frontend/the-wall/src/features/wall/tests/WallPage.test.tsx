import { render, screen } from "@testing-library/react";
import userEvent from "@testing-library/user-event";
import { describe, it, expect, vi } from "vitest";
import WallPage from "../WallPage";
import { fetchPhrases } from '../services/phraseService'

vi.mock('../services/phraseService', () => ({
    fetchPhrases: vi.fn()
}));

describe("WallPage", () => {
    it("display loading state while phrases are being loaded", async () => {
        (fetchPhrases as vi.Mock).mockImplementation(
            () => new Promise(() => { })
        );

        // Given the user opens the wall page
        render(<WallPage />);

        // When phrases are being fetched

        // Then a loading indicator is displayed
        expect(screen.getByLabelText(/loading/i)).toBeInTheDocument();
    });
});

describe("WallPage", () => {
    it("display phrases on the wall", async ()=>{
        (fetchPhrases as vi.Mock).mockResolvedValue([{
            "phraseText": "Hello world",
        }]);

        // Given the wall page is open
        render(<WallPage/>);
        // And phrases have been loaded
    
        // Then a list of phrases is displayed on the wall
        expect(await screen.findByText("Hello world")).toBeInTheDocument();

    });
});

describe("WallPage", () => {
    it("allows publishing a phrase from the wall", async () => {
        const user = userEvent.setup();

        (fetchPhrases as vi.Mock).mockResolvedValue([]);

        // Given the wall page is open
        render(<WallPage />);

        // And the publish phrase form is displayed

        const textArea = await screen.findByRole("textbox");
        expect(textArea).toBeInTheDocument();

        const fontSelect = screen.getByLabelText(/font/i);
        expect(fontSelect).toBeInTheDocument();

        const fontSizeSelect = screen.getByLabelText(/size/i);
        expect(fontSizeSelect).toBeInTheDocument();

        const colorInput = screen.getByLabelText(/color/i);
        expect(colorInput).toBeInTheDocument();

        // When the user submits a phrase with text and style (font, fontsize and color)
        await user.type(textArea, "Hello world!");
        await user.selectOptions(fontSelect, "Arial");
        await user.selectOptions(fontSizeSelect, "10");
        await user.type(colorInput, "#ff0000");

        const publishButton = screen.getByRole("button", {
            name: /publish/i
        });

        await user.click(publishButton);

        // Then the wall is refreshed
        // And the new phrase is displayed prominently
        expect(screen.getByText("Hello world!")).toBeInTheDocument();
    });
});