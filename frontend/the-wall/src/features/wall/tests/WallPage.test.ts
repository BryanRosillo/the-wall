import {render, screen} from "@testing-library/react";
import userEvent from "@testing-library/user-event";
import {describe, it, expect} from "vitest";

describe("WallPage",() => {
    it("allows publishing a phrase from the wall", async () =>{
        const user = userEvent.setup();

        // Given the wall page is open
        render(<WallPage />);

        // And the publish phrase form is displayed
        const textArea = screen.getByRole("textbox");
        expect(textArea).toBeInTheDocument();

        // When the user submits a phrase with text and style
        await user.type(textArea, "Hello world!");

        const publishButton = screen.getByRole("button",{
            name: /publish/i
        });

        await user.click(publishButton);

        // Then the wall is refreshed
        // And the new phrase is displayed prominently
        expect(screen.getByText("Hello world!")).toBeInTheDocument();
    });
});