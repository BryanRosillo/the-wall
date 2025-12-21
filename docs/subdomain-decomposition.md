## Defining services using the Decompose by Sub-domain pattern

To identify the responsibilities of each service, user stories were analyzed and grouped according to the system capability they represent. Each group defines a sub-domain, which encapsulates a cohesive set of responsibilities.

### Sub-domain to User Story Mapping

| Sub-domain     | User Stories |
|---------------|--------------|
| **Identity** | User Story 1.1 – Register an account<br>User Story 1.2 – Log in<br>User Story 1.3 – Log out |
| **Phrase** | User Story 2.1 – Publish a phrase<br>User Story 2.2 – View the wall |
| **Interaction** | User Story 3.1 – Comment on a phrase<br>User Story 3.2 – React to a phrase |
| **Notification** | User Story 4.1 – Receive a notification for comments<br>User Story 4.2 – Receive a notification for reactions<br>User Story 4.3 – View notifications |

### Architectural Decision

Each sub-domain is represented by a single bounded context. At this stage of the project, each bounded context may be implemented as an independent service. This decision is subject to change as the system evolves and new requirements emerge.
