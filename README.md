# 📄 Policy Portal

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2%2B-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET Web Forms](https://img.shields.io/badge/ASP.NET-Web%20Forms-%233498DB?logo=asp.net&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-forms)
[![Language](https://img.shields.io/badge/Language-C%23-%23239120?logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Build](https://img.shields.io/badge/Build-MSBuild-blue)](https://visualstudio.microsoft.com/msbuild/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

> A secure, Active Directory-integrated **ASP.NET Web Forms** application for centralized IT Policy management, acknowledgment tracking, and compliance verification.

---

## 📖 Table of Contents
- [Overview](#-overview)
- [✨ Key Features](#-key-features)
- [🛠 Tech Stack](#-tech-stack)
- [📂 Project Structure](#-project-structure)
- [⚙️ Prerequisites](#️-prerequisites)
- [🚀 Installation & Setup](#-installation--setup)
- [🔧 Configuration](#-configuration)
- [📦 Deployment](#-deployment)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)

---

## 🎯 Overview

**Policy Portal** is an internal enterprise web application designed to streamline the distribution, acknowledgment, and verification of IT Governance policies. It replaces manual email/PDF workflows with an automated, auditable platform featuring **Single Sign-On (SSO) via Active Directory**, interactive **policy quizzes**, and digital **acknowledgment tracking**.

### The Problem it Solves
- ❌ **Manual Tracking**: Chasing employees for policy sign-offs via email.
- ❌ **No Verification**: Employees "sign" without reading content.
- ❌ **Audit Nightmares**: Scattered records across inboxes and shared drives.
- ✅ **Policy Portal Solution**: Centralized repository, enforced reading via quizzes, immutable audit logs, and AD integration.

---

## ✨ Key Features

| Category | Feature | Description |
| :--- | :--- | :--- |
| **🔐 Authentication** | **Windows/AD Integrated Auth** | Seamless SSO using `ActiveDirectoryHelper` & `ADManager`; no separate credentials required. |
| | **User Context Resolution** | Auto-fetches Display Name, Email, Department, Manager via `ADUserDetail` & `ADProperties`. |
| **📚 Policy Management** | **Document Repository** | Serves 20+ governed PDF policies (Change Mgmt, Asset Mgmt, Security, DR, etc.) from `/Files`. |
| | **Dynamic Rendering** | `PolicyForm.aspx` dynamically binds policy list; `ThankyouForm` handles acknowledgment logic. |
| **🧠 Compliance Verification** | **Interactive Quiz Engine** | `Quiz.aspx` enforces knowledge checks per policy before acknowledgment is recorded. |
| | **Score Thresholds** | Configurable pass/fail logic to ensure comprehension. |
| **🎨 UI/UX** | **Master Page Architecture** | Consistent branding (`Site1.Master`) with Jubilee logo assets. |
| | **Responsive Styling** | Custom CSS (`StyleSheet1.css`, `loginpage.css`) for clean, accessible interface. |
| **🛡 Security** | **Web.config Transformations** | Separate `Debug` / `Release` configs for connection strings & auth modes. |
| | **Request Validation** | Built-in ASP.NET validation & ViewState MAC protection. |

---

## 🛠 Tech Stack

| Layer | Technology | Details |
| :--- | :--- | :--- |
| **Runtime** | **.NET Framework 4.7.2+** | Target framework deduced from `Policy_Portal.csproj` & `Web.config`. |
| **Web Framework** | **ASP.NET Web Forms** | `.aspx`, `.aspx.cs`, `.designer.cs` code-behind model. |
| **Language** | **C# 7.3+** | Business logic in `*.cs` helpers and code-behind files. |
| **Directory Services** | **System.DirectoryServices / AccountManagement** | `ADManager.cs`, `ActiveDirectoryHelper.cs` for LDAP queries. |
| **Package Manager** | **NuGet (packages.config)** | Legacy package management (pre-PackageReference). |
| **Build System** | **MSBuild / Visual Studio Solution (`.sln`)** | Dual solution files (Root & Subfolder). |
| **Frontend** | **HTML5, CSS3, WebForms Controls** | Master Pages, User Controls, Server Controls. |
| **Deployment Target** | **IIS 8.5+ / Windows Server** | Standard ASP.NET hosting pipeline. |
| **Document Storage** | **File System (Content/Files)** | PDF policies stored directly in repo `/Files` & `/Policy_Portal/Files`. |

---

## 📂 Project Structure

```text
Policy_Portal/                    # Primary Application Root (Solution lives here)
├── 📄 Policy_Portal.sln          # Visual Studio Solution File
├── 📄 Policy_Portal.csproj       # Project File (MSBuild)
├── 📄 Web.config                 # Main Configuration (Auth, ConnectionStrings, AppSettings)
├── 📄 Web.Debug.config           # Debug Transforms
├── 📄 Web.Release.config         # Release Transforms
├── 📄 packages.config            # NuGet Dependencies
├── 📄 Global.asax / .cs          # Application Lifecycle Events
├── 📁 Properties/
│   └── 📄 AssemblyInfo.cs        # Assembly Metadata (Version, Title, GUID)
├── 📁 Files/                     # Policy Documents (PDFs) - 20+ Files
│   ├── Change Management.pdf
│   ├── IT Asset Management.pdf
│   ├── Backup Restoration and Retention Policy.pdf
│   └── ... (see file list for full index)
├── 📄 Site1.Master / .cs / .designer.cs  # Master Page Layout & Logic
├── 📄 LoginPage.aspx / .cs / .designer.cs # AD Login Entry Point
├── 📄 PolicyForm.aspx / .cs / .designer.cs # Policy Listing & Selection
├── 📄 Quiz.aspx / .cs / .designer.cs      # Compliance Quiz Engine
├── 📄 ThankyouForm.aspx / .cs / .designer.cs # Acknowledgment Submission
├── 📄 ADManager.cs               # Core AD Operations (Search, Auth, Props)
├── 📄 ActiveDirectoryHelper.cs   # Helper wrappers for DirectoryServices
├── 📄 ADUserDetail.cs            # DTO for User Attributes
├── 📄 ADProperties.cs            # AD Property Name Constants
├── 📄 StyleSheet1.css            # Global Application Styles
├── 📄 loginpage.css              # Login Page Specific Styles
├── 📄 pngegg.png / Jubilee_Logo_2-bgr.png # Branding Assets
└── 📄 README.md                  # This File
```

> **Note**: The repository root contains a mirror copy of the `Policy_Portal` folder. The **active development solution** is located at `./Policy_Portal/Policy_Portal.sln`.

---

## ⚙️ Prerequisites

Before you begin, ensure you have the following installed:

1.  **Visual Studio 2019/2022** (with **ASP.NET and web development** workload).
2.  **.NET Framework 4.7.2 Developer Pack** (or version specified in `.csproj` `<TargetFrameworkVersion>`).
3.  **IIS Express** (included with VS) or **Full IIS 8.5+** for local hosting.
4.  **Active Directory Access**: Domain credentials with **Read** permissions on User objects (for `ADManager` queries).
5.  **Git** for version control.

---

## 🚀 Installation & Setup

### 1. Clone the Repository
```bash
git clone https://github.com/your-org/Policy_Portal.git
cd Policy_Portal
```

### 2. Open Solution in Visual Studio
Open **`./Policy_Portal/Policy_Portal.sln`** (Not the root `.sln` if duplicates exist).

### 3. Restore NuGet Packages
*   **Automatic**: Right-click Solution → **Restore NuGet Packages**.
*   **CLI**:
    ```bash
    nuget restore Policy_Portal/Policy_Portal.sln
    ```

### 4. Configure `Web.config` (Critical)
The application **will not run** without valid AD configuration. Open `Policy_Portal/Web.config` and update:

```xml
<configuration>
  <connectionStrings>
    <!-- AD Connection String for System.DirectoryServices -->
    <add name="ADConnectionString" 
         connectionString="LDAP://YOUR.DOMAIN.COM/DC=YOUR,DC=DOMAIN,DC=COM" 
         providerName="System.Data.SqlClient" /> <!-- Provider name often ignored for LDAP -->
  </connectionStrings>

  <appSettings>
    <!-- Domain NetBIOS name (e.g., CORP) -->
    <add key="DomainName" value="YOUR_DOMAIN" />
    
    <!-- Service Account for privileged AD queries (if not using App Pool Identity) -->
    <add key="ServiceAccountUser" value="svc_PolicyPortal" />
    <add key="ServiceAccountPassword" value="********" /> <!-- Use Secure Store / Key Vault in Prod! -->
    
    <!-- Quiz Pass Threshold (Percentage) -->
    <add key="QuizPassThreshold" value="80" />
  </appSettings>

  <system.web>
    <!-- Windows Auth Required for SSO -->
    <authentication mode="Windows" />
    <authorization>
      <deny users="?" /> <!-- Deny Anonymous -->
    </authorization>
    <identity impersonate="false" /> <!-- Use App Pool Identity -->
  </system.web>
</configuration>
```

### 5. Build Solution
`Ctrl + Shift + B` or **Build > Build Solution**. Ensure 0 errors.

### 6. Run Locally (IIS Express)
Press `F5` or `Ctrl + F5` (Start Without Debugging).
*   Browser launches `LoginPage.aspx`.
*   Windows Auth prompts (if not logged in) or auto-logs you in.
*   Redirects to `PolicyForm.aspx` on success.

---

## 🔧 Configuration Deep Dive

### Active Directory Integration (`ADManager.cs` / `ActiveDirectoryHelper.cs`)
The portal uses a **Service Account** (configured in `Web.config` `AppSettings`) to perform LDAP searches (`DirectorySearcher`) for:
*   Current User Details (`UserPrincipal.Current`).
*   Manager Hierarchy (for escalation/approval workflows).
*   Department/OU validation.

**Required Service Account Permissions:**
*   **Read** on User Objects (cn=user,ou=People,dc=domain,dc=com).
*   **Read** on Group Membership (TokenGroups).

### Policy Document Management
Policies are **static PDF files** located in:
1.  `./Policy_Portal/Files/` (Primary - Used by Build/Deploy)
2.  `./Files/` (Mirror - Repository Root)

**To Add/Update a Policy:**
1.  Drop PDF into `Policy_Portal/Files/`.
2.  Update `PolicyForm.aspx.cs` `BindPolicyGrid()` or data source to include new file metadata (Title, Category, Effective Date, Version).
3.  Rebuild.

### Quiz Logic (`Quiz.aspx.cs`)
Questions/Answers are currently **hardcoded or XML/DB backed** (check `Quiz.aspx.cs` `Page_Load` / `BindQuestions`).
*   *Recommendation*: Move to SQL DB or JSON config for non-dev updates.

---

## 📦 Deployment (Production)

### 1. Publish Profile (Visual Studio)
1.  Right-click `Policy_Portal` Project → **Publish**.
2.  Target: **Folder** or **IIS (Web Deploy)**.
3.  Configuration: **Release**.
4.  **File Publish Options**: Check "Remove additional files at destination" (first deploy only).
5.  Click **Publish**.

### 2. IIS Server Setup
1.  **App Pool**: Create `PolicyPortalAppPool` → **.NET CLR v4.0** → **Integrated Pipeline** → **Identity**: `Domain\svc_PolicyPortal` (Service Account).
2.  **Website**: Point Physical Path to Published Output (e.g., `C:\inetpub\PolicyPortal`).
3.  **Authentication**: Enable **Windows Authentication**; Disable **Anonymous**.
4.  **Authorization**: Add `Domain Users` Allow Rule.
5.  **SSL**: Bind HTTPS Certificate (Required for AD Credentials integrity).

### 3. Post-Deploy Config
*   Verify `Web.Release.config` transforms applied (connectionStrings, debug="false", customErrors="RemoteOnly").
*   Test AD Login with a standard user.
*   Verify PDF download/rendering in `PolicyForm`.
*   Run through a full Quiz -> ThankYou flow.

---

## 🤝 Contributing

We welcome contributions! Please follow the standard Gitflow workflow:

1.  **Fork** the repository.
2.  Create a feature branch: `git checkout -b feature/QuizRandomization`.
3.  Commit changes: `git commit -m 'feat: Add question randomization logic'`.
4.  Push to branch: `git push origin feature/QuizRandomization`.
5.  Open a **Pull Request** against `main`/`master`.

### Coding Standards
*   **C#**: Follow Microsoft C# Coding Conventions (PascalCase public, camelCase private).
*   **WebForms**: Keep logic in Code-Behind (`.aspx.cs`); minimize inline `<% %>` blocks.
*   **CSS**: Use `StyleSheet1.css` for globals; page-specific in `loginpage.css`.
*   **Comments**: XML Doc comments (`///`) for all public methods in `ADManager`, `Helpers`.

---

## 📄 License

Distributed under the **MIT License**. See `LICENSE` file for more information (create one if missing).

---

## 🙏 Acknowledgements
*   **Microsoft** for ASP.NET Web Forms & System.DirectoryServices.
*   **Jubilee Insurance** (Assumed from Logo assets) for domain context.
*   **NuGet** packages referenced in `packages.config` (Newtonsoft.Json, etc.).

---

> **Maintained with ❤️ by the IT Governance Team.**