---


---

<p>Міністерство освіти і науки України</p>
<p>Київський авіаційний інститут</p>
<p>Факультет кібербезпеки, комп’ютерної та програмної інженерії</p>
<p>Кафедра інженерії програмного забезпечення</p>
<p>ЛАБОРАТОРНА РОБОТА 1</p>
<p>з дисципліни</p>
<p>«Конструювання та документування програмного забезпечення»</p>
<p>Виконав: студент гр. ПІ-121:2</p>
<p>Івашко Іван Андрійович</p>
<p>прізвище, ім’я, по батькові студента</p>
<p>Прийняв:</p>
<p>Роман Ігорович Малькевич</p>
<p>КИЇВ 2026</p>
<h1 id="🧪-laboratory-work-1">🧪 Laboratory Work 1</h1>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-laboratory-work-1"></a></p>
<h2 id="designing-a-messaging-system">Designing a Messaging System</h2>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#designing-a-messaging-system"></a></p>
<h3 id="🎯-goal">🎯 Goal</h3>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-goal"></a></p>
<p>Learn how to:</p>
<ul>
<li>design software systems before coding;</li>
<li>reason about architecture and responsibilities;</li>
<li>use Component, Sequence, and State diagrams;</li>
<li>document decisions using RFC and ADR.</li>
</ul>
<hr>
<h2 id="🧠-context">🧠 Context</h2>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-context"></a></p>
<p>You are designing a <strong>minimal messenger system</strong> that supports:</p>
<ul>
<li>sending messages between users;</li>
<li>asynchronous delivery;</li>
<li>message statuses (sent / delivered / read);</li>
<li>offline users.</li>
</ul>
<p>❗ No code is required. You act as a <strong>system designer / tech lead</strong>.</p>
<hr>
<h2 id="🧩-functional-requirements">🧩 Functional Requirements</h2>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-functional-requirements"></a></p>
<ol>
<li>A user can send a message to another user.</li>
<li>Each message has a lifecycle.</li>
<li>The system must:
<ul>
<li>store messages,</li>
<li>deliver them asynchronously,</li>
<li>update delivery status.</li>
</ul>
</li>
<li>The recipient may be online or offline.</li>
</ol>
<hr>
<h2 id="🧱-part-1-—-component-diagram-30">🧱 Part 1 — Component Diagram (30%)</h2>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-part-1--component-diagram-30"></a></p>
<h3 id="task">Task</h3>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#task"></a></p>
<p>Create a <strong>Component Diagram</strong> that shows:</p>
<ul>
<li>system components,</li>
<li>their responsibilities,</li>
<li>interactions between them.</li>
</ul>
<h3 id="required-components">Required components</h3>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#required-components"></a></p>
<ul>
<li>Client (Web / Mobile)</li>
<li>Backend API</li>
<li>Message Service</li>
<li>Database</li>
<li>Delivery mechanism (Queue / WebSocket / Push)</li>
</ul>
<h3 id="example-mermaid">Example (Mermaid)</h3>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#example-mermaid"></a></p>
<p>
</p>
<hr>
<h2 id="🔁-part-2-—-sequence-diagram-25">🔁 Part 2 — Sequence Diagram (25%)</h2>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-part-2--sequence-diagram-25"></a></p>
<h3 id="scenario">Scenario</h3>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#scenario"></a></p>
<p>User <strong>A sends a message</strong> to user <strong>B who is offline</strong>.</p>
<h3 id="task-1">Task</h3>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#task-1"></a></p>
<p>Describe the interaction sequence in time.</p>
<p>
</p>
<hr>
<h2 id="🔄-part-3-—-state-diagram-20">🔄 Part 3 — State Diagram (20%)</h2>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-part-3--state-diagram-20"></a></p>
<h3 id="object">Object</h3>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#object"></a></p>
<p><code>Message</code></p>
<h3 id="task-2">Task</h3>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#task-2"></a></p>
<p>Describe the <strong>message lifecycle</strong>.</p>
<p>
</p>
<hr>
<h2 id="📚-part-4-—-adr-architecture-decision-record-25">📚 Part 4 — ADR (Architecture Decision Record) (25%)</h2>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-part-4--adr-architecture-decision-record-25"></a></p>
<h3 id="task-3">Task</h3>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#task-3"></a></p>
<p>Document <strong>one architecture decision</strong>.</p>
<h1 id="adr-001-use-message-queue-for-delivery">ADR-001: Use Message Queue for Delivery</h1>
<h2 id="status">Status</h2>
<p>Accepted</p>
<h2 id="context">Context</h2>
<p>Users can be online or offline when messages are sent.</p>
<h2 id="decision">Decision</h2>
<p>Use asynchronous delivery with a queue and client acknowledgements.</p>
<h2 id="alternatives">Alternatives</h2>
<ul>
<li>Direct delivery only (rejected)</li>
<li>Client polling (considered)</li>
</ul>
<h2 id="consequences">Consequences</h2>
<ul>
<li>Reliable delivery</li>
</ul>
<ul>
<li>Increased system complexity</li>
</ul>
<hr>
<h1 id="🧪-laboratory-variants-—-messenger-system-design">🧪 Laboratory Variants — Messenger System Design</h1>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-laboratory-variants--messenger-system-design"></a></p>
<p>Each student (or team) chooses <strong>one variant</strong>.<br>
For the chosen variant, you must deliver:</p>
<ul>
<li>Component Diagram</li>
<li>Sequence Diagram (one key scenario)</li>
<li>State Diagram (one main entity)</li>
<li>1 ADR</li>
</ul>
<h2 id="🔹-variant-4-—-group-chat">🔹 Variant 4 — Group Chat</h2>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-variant-4--group-chat"></a></p>
<h2 id="🔹-variant-4-—-group-chat-1">🔹 Variant 4 — Group Chat</h2>
<p><a href="https://github.com/rmalkevy/Software-Design-and-Documentation/blob/main/lab-1.md#-variant-4--group-chat"></a></p>
<p><strong>Focus:</strong> scaling delivery logic</p>
<p><strong>Additional requirements:</strong></p>
<ul>
<li>Messages sent to multiple recipients</li>
<li>Separate delivery status per recipient</li>
</ul>
<p><strong>Key questions:</strong></p>
<ul>
<li>Fan-out strategy</li>
<li>Performance implications</li>
</ul>
<pre class=" language-mermaid"><svg id="mermaid-svg-415UmcTyKzXgsss5" width="100%" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" height="267.0599670410156" style="max-width: 342.1933288574219px;" viewBox="0 0 342.1933288574219 267.0599670410156"><style>#mermaid-svg-415UmcTyKzXgsss5{font-family:"trebuchet ms",verdana,arial,sans-serif;font-size:16px;fill:#000000;}#mermaid-svg-415UmcTyKzXgsss5 .error-icon{fill:#552222;}#mermaid-svg-415UmcTyKzXgsss5 .error-text{fill:#552222;stroke:#552222;}#mermaid-svg-415UmcTyKzXgsss5 .edge-thickness-normal{stroke-width:2px;}#mermaid-svg-415UmcTyKzXgsss5 .edge-thickness-thick{stroke-width:3.5px;}#mermaid-svg-415UmcTyKzXgsss5 .edge-pattern-solid{stroke-dasharray:0;}#mermaid-svg-415UmcTyKzXgsss5 .edge-pattern-dashed{stroke-dasharray:3;}#mermaid-svg-415UmcTyKzXgsss5 .edge-pattern-dotted{stroke-dasharray:2;}#mermaid-svg-415UmcTyKzXgsss5 .marker{fill:#666;stroke:#666;}#mermaid-svg-415UmcTyKzXgsss5 .marker.cross{stroke:#666;}#mermaid-svg-415UmcTyKzXgsss5 svg{font-family:"trebuchet ms",verdana,arial,sans-serif;font-size:16px;}#mermaid-svg-415UmcTyKzXgsss5 .label{font-family:"trebuchet ms",verdana,arial,sans-serif;color:#000000;}#mermaid-svg-415UmcTyKzXgsss5 .cluster-label text{fill:#333;}#mermaid-svg-415UmcTyKzXgsss5 .cluster-label span{color:#333;}#mermaid-svg-415UmcTyKzXgsss5 .label text,#mermaid-svg-415UmcTyKzXgsss5 span{fill:#000000;color:#000000;}#mermaid-svg-415UmcTyKzXgsss5 .node rect,#mermaid-svg-415UmcTyKzXgsss5 .node circle,#mermaid-svg-415UmcTyKzXgsss5 .node ellipse,#mermaid-svg-415UmcTyKzXgsss5 .node polygon,#mermaid-svg-415UmcTyKzXgsss5 .node path{fill:#eee;stroke:#999;stroke-width:1px;}#mermaid-svg-415UmcTyKzXgsss5 .node .label{text-align:center;}#mermaid-svg-415UmcTyKzXgsss5 .node.clickable{cursor:pointer;}#mermaid-svg-415UmcTyKzXgsss5 .arrowheadPath{fill:#333333;}#mermaid-svg-415UmcTyKzXgsss5 .edgePath .path{stroke:#666;stroke-width:1.5px;}#mermaid-svg-415UmcTyKzXgsss5 .flowchart-link{stroke:#666;fill:none;}#mermaid-svg-415UmcTyKzXgsss5 .edgeLabel{background-color:white;text-align:center;}#mermaid-svg-415UmcTyKzXgsss5 .edgeLabel rect{opacity:0.5;background-color:white;fill:white;}#mermaid-svg-415UmcTyKzXgsss5 .cluster rect{fill:hsl(210,66.6666666667%,95%);stroke:#26a;stroke-width:1px;}#mermaid-svg-415UmcTyKzXgsss5 .cluster text{fill:#333;}#mermaid-svg-415UmcTyKzXgsss5 .cluster span{color:#333;}#mermaid-svg-415UmcTyKzXgsss5 div.mermaidTooltip{position:absolute;text-align:center;max-width:200px;padding:2px;font-family:"trebuchet ms",verdana,arial,sans-serif;font-size:12px;background:hsl(-160,0%,93.3333333333%);border:1px solid #26a;border-radius:2px;pointer-events:none;z-index:100;}#mermaid-svg-415UmcTyKzXgsss5:root{--mermaid-font-family:"trebuchet ms",verdana,arial,sans-serif;}#mermaid-svg-415UmcTyKzXgsss5 flowchart{fill:apa;}</style><g><g class="output"><g class="clusters"></g><g class="edgePaths"><g class="edgePath LS-A LE-B" style="opacity: 1;" id="L-A-B"><path class="path" d="M68.19999694824219,133.5149917602539L93.19999694824219,133.5149917602539L118.19999694824219,133.5149917602539" marker-end="url(https://stackedit.io/app#arrowhead80)" style="fill:none"></path><defs><marker id="arrowhead80" viewBox="0 0 10 10" refX="9" refY="5" markerUnits="strokeWidth" markerWidth="8" markerHeight="6" orient="auto"><path d="M 0 0 L 10 5 L 0 10 z" class="arrowheadPath" style="stroke-width: 1px; stroke-dasharray: 1px, 0px;"></path></marker></defs></g><g class="edgePath LS-B LE-C" style="opacity: 1;" id="L-B-C"><path class="path" d="M170.82544999142272,107.55308589174163L208.63333129882812,58.249996185302734L234.1633308410644,58.749996185302734" marker-end="url(https://stackedit.io/app#arrowhead81)" style="fill:none"></path><defs><marker id="arrowhead81" viewBox="0 0 10 10" refX="9" refY="5" markerUnits="strokeWidth" markerWidth="8" markerHeight="6" orient="auto"><path d="M 0 0 L 10 5 L 0 10 z" class="arrowheadPath" style="stroke-width: 1px; stroke-dasharray: 1px, 0px;"></path></marker></defs></g><g class="edgePath LS-B LE-D" style="opacity: 1;" id="L-B-D"><path class="path" d="M170.82544999142272,159.47689762876618L208.63333129882812,208.77998733520508L234.13333129882812,209.27998733520508" marker-end="url(https://stackedit.io/app#arrowhead82)" style="fill:none"></path><defs><marker id="arrowhead82" viewBox="0 0 10 10" refX="9" refY="5" markerUnits="strokeWidth" markerWidth="8" markerHeight="6" orient="auto"><path d="M 0 0 L 10 5 L 0 10 z" class="arrowheadPath" style="stroke-width: 1px; stroke-dasharray: 1px, 0px;"></path></marker></defs></g></g><g class="edgeLabels"><g class="edgeLabel" style="opacity: 1;" transform=""><g transform="translate(0,0)" class="label"><rect rx="0" ry="0" width="0" height="0"></rect><foreignObject width="0" height="0"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; white-space: nowrap;"><span id="L-L-A-B" class="edgeLabel L-LS-A' L-LE-B"></span></div></foreignObject></g></g><g class="edgeLabel" style="opacity: 1;" transform=""><g transform="translate(0,0)" class="label"><rect rx="0" ry="0" width="0" height="0"></rect><foreignObject width="0" height="0"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; white-space: nowrap;"><span id="L-L-B-C" class="edgeLabel L-LS-B' L-LE-C"></span></div></foreignObject></g></g><g class="edgeLabel" style="opacity: 1;" transform=""><g transform="translate(0,0)" class="label"><rect rx="0" ry="0" width="0" height="0"></rect><foreignObject width="0" height="0"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; white-space: nowrap;"><span id="L-L-B-D" class="edgeLabel L-LS-B' L-LE-D"></span></div></foreignObject></g></g></g><g class="nodes"><g class="node default" style="opacity: 1;" id="flowchart-A-332" transform="translate(38.099998474121094,133.5149917602539)"><rect rx="0" ry="0" x="-30.099998474121094" y="-23.35832977294922" width="60.19999694824219" height="46.71665954589844" class="label-container"></rect><g class="label" transform="translate(0,0)"><g transform="translate(-20.099998474121094,-13.358329772949219)"><foreignObject width="40.19999694824219" height="26.716659545898438"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; white-space: nowrap;">User1</div></foreignObject></g></g></g><g class="node default" style="opacity: 1;" id="flowchart-B-333" transform="translate(150.91666412353516,133.5149917602539)"><circle x="-32.71666717529297" y="-23.35832977294922" r="32.71666717529297" class="label-container"></circle><g class="label" transform="translate(0,0)"><g transform="translate(-22.71666717529297,-13.358329772949219)"><foreignObject width="45.43333435058594" height="26.716659545898438"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; white-space: nowrap;">Server</div></foreignObject></g></g></g><g class="node default" style="opacity: 1;" id="flowchart-C-335" transform="translate(283.91332626342773,58.249996185302734)"><polygon points="50.249995422363284,0 100.49999084472657,-50.249995422363284 50.249995422363284,-100.49999084472657 0,-50.249995422363284" transform="translate(-50.249995422363284,50.249995422363284)" class="label-container"></polygon><g class="label" transform="translate(0,0)"><g transform="translate(-22.474998474121094,-13.358329772949219)"><foreignObject width="44.94999694824219" height="26.716659545898438"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; white-space: nowrap;">Admin</div></foreignObject></g></g></g><g class="node default" style="opacity: 1;" id="flowchart-D-337" transform="translate(283.91332626342773,208.77998733520508)"><polygon points="50.27999496459961,0 100.55998992919922,-50.27999496459961 50.27999496459961,-100.55998992919922 0,-50.27999496459961" transform="translate(-50.27999496459961,50.27999496459961)" class="label-container"></polygon><g class="label" transform="translate(0,0)"><g transform="translate(-22.508331298828125,-13.358329772949219)"><foreignObject width="45.01666259765625" height="26.716659545898438"><div xmlns="http://www.w3.org/1999/xhtml" style="display: inline-block; white-space: nowrap;">User 2</div></foreignObject></g></g></g></g></g></g></svg></pre>
<p><a href="https://github.com/HoatzinDev/Messenger-Maks1">https://github.com/HoatzinDev/Messenger-Maks1</a></p>

