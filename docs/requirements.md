# The Wall – Requirements

## Theme
Social wall for sharing phrases and opinions.

---

# Epic 1: User Management (Authentication)

## User Story 1.1 – Register an account
**As a visitor**  
I want to create an account  
So that I can participate by posting phrases and comments.

### Acceptance Criteria
- **Given** a visitor with valid user details (username, image, email, password)  
  **When** they submit the registration form  
  **Then** the system creates the account and allows them to log in.
- **Given** a visitor using an already registered email  
  **Then** the system displays an error message.

---

## User Story 1.2 – Log in
**As a registered user**  
I want to log in  
So that I can access the wall and interact within the platform.

### Acceptance Criteria
- **Given** a registered user with valid credentials  
  **When** they log in  
  **Then** the system grants access.
- **Given** invalid login credentials  
  **Then** the system displays an error message.

---

## User Story 1.3 – Log out
**As a logged-in user**  
I want to log out  
So that I can end my session securely.

### Acceptance Criteria
- **Given** an authenticated user  
  **When** they log out  
  **Then** their session is invalidated and they return to the public view.

---

# Epic 2: Phrase Management

## User Story 2.1 – Publish a phrase
**As a logged-in user**  
I want to publish a phrase on the wall  
So that I can share my ideas with other users.

### Acceptance Criteria
- **Given** an authenticated user and a valid phrase with a style (font, font size amd color)
  **When** they publish the phrase  
  **Then** it becomes visible to all users  
  And it is associated with the posting user  
  And the user’s name or alias is displayed  
  And the phrase appears on the wall.
- **If** the phrase is empty or exceeds the character limit  
  **Then** the system displays an error.

---

## User Story 2.2 – View the wall
**As a user or visitor**  
I want to view all published phrases  
So that I can explore ideas shared by the community.

### Acceptance Criteria
- **Given** a user or visitor  
  **When** they access the wall  
  **Then** they see a list of phrases.
- Each phrase shows:  
  - the phrase text  
  - the author’s name  
  - reaction counters  
  - number of comments

---

# Epic 3: User Interactions

## User Story 3.1 – Comment on a phrase
**As a logged-in user**  
I want to write a comment on a phrase  
So that I can share my opinion with the author and other users.

### Acceptance Criteria
- **Given** an authenticated user and a valid comment  
  **When** they submit the comment  
  **Then** it becomes visible below the phrase  
  And it is linked to both the user and the phrase.
- **If** the comment is empty  
  **Then** the system displays an error.

---

## User Story 3.2 – React to a phrase
**As a logged-in user**  
I want to react to a phrase  
So that I can express agreement or disagreement.

### Acceptance Criteria
- **Given** a user and a valid reaction (agree / disagree)  
  **When** they react to a phrase  
  **Then** the corresponding reaction counter increases by 1  
  And the reaction is associated with the user and the phrase.
- **If** the user has already reacted to the phrase  
  **When** they change their reaction  
  **Then** their previous reaction is updated  
  And reaction counters are adjusted accordingly.

---

# Epic 4: Notifications

## User Story 4.1 – Receive a notification for comments
**As the author of a phrase**  
I want to receive a notification when someone comments on it  
So that I can stay aware of the conversation.

### Acceptance Criteria
- **Given** an author and a new comment on their phrase  
  **When** another user posts a comment  
  **Then** the system generates a notification  
  Including who commented and on which phrase.

---

## User Story 4.2 – Receive a notification for reactions
**As the author of a phrase**  
I want to be notified when users react to it  
So that I can know how people feel about my idea.

### Acceptance Criteria
- **Given** an author and a reaction on their phrase  
  **When** another user reacts  
  **Then** a notification is generated  
  Including the type of reaction and the reacting user.

---

## User Story 4.3 – View notifications
**As a logged-in user**  
I want to view my notifications  
So that I can see all interactions related to my phrases.

### Acceptance Criteria
- **Given** a user with unread notifications  
  **When** they open the notifications panel  
  **Then** they see all notifications ordered by date.
- **When** notifications are opened  
  **Then** they are marked as read.

---

# Epic 5: Creative Graffiti-Style Wall

## User Story 5.1 – Display phrases with graffiti-style randomization
**As a user**  
I want to see phrases displayed with creative visual variation  
So that the wall feels like a real graffiti wall.

### Acceptance Criteria
- Phrases are displayed with:
  - random rotation angles  
  - varying font sizes  
  - predefined random colors  
  - randomized positions inside the wall container
